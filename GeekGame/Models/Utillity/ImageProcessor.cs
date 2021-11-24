using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GeekGame.Models.Utillity
{
    public class ImageProcessor
    {
        public Image ResizeImage(Bitmap image)
        {
            float maxWidth = 900;
            float maxHeight = 900;

            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = maxWidth / originalWidth;
            float ratioY = maxHeight / originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

            // Create an Encoder object for the Quality parameter.
            Encoder encoder = Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, 72);
            encoderParameters.Param[0] = encoderParameter;
            return (Image)newImage;

        }

        public ImageErrorMessage CheckPic(IFormFile Pic)
        {
            ImageErrorMessage e = new ImageErrorMessage();
            string strfilename = Path.GetFileName(Pic.FileName);
            string strfileextension = Path.GetExtension(strfilename).ToLower();
            if ((strfileextension != ".jpg") &&
                (strfileextension != ".jpeg") &&
                (strfileextension != ".jpe") &&
                (strfileextension != ".png") &&
                (strfileextension != ".bmp"))
            {
                e.ErrorMessage = "Please choose a right format for the image ";
                e.HasError = false;
                return e;
            }

            if (Pic.Length == 0)
            {
                e.ErrorMessage = "There was a problem with uploading the image. Please try again.";
                e.HasError = false;
                return e;
            }
            if (Pic.Length > 2000 * 1024)
            {
                e.ErrorMessage = "The image size is greater than 2 MB ";
                e.HasError = false;
                return e;
            }
            e.HasError = true;
            e.ErrorMessage = "OK";
            return e;
        }

        public class ImageErrorMessage
        {
            public Boolean HasError { get; set; }
            public string ErrorMessage { get; set; }
        }

        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }

    }
}
