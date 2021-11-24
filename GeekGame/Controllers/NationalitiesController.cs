using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeekGame.Models;
using Microsoft.AspNetCore.Http;
using GeekGame.Models.Utillity;
using static GeekGame.Models.Utillity.ImageProcessor;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Drawing;

namespace GeekGame.Controllers
{
    public class NationalitiesController : Controller
    {
        private readonly DataBaseContext _context;
        private IWebHostEnvironment _hostingEnvironment;
        public NationalitiesController(DataBaseContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TblNationality.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            return View(await _context.TblNationality.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Image,Nationality")] TblNationality tblNationality, IFormFile natlImage)
        {
            if (ModelState.IsValid)
            {
                if (natlImage == null)
                {
                    ViewBag.ErrorMessage = "Please choose an image.";
                    return View();
                }
                ImageProcessor imageproccess = new ImageProcessor();
                ImageErrorMessage imgErrMsg = new ImageErrorMessage();

                //get image Name
                string picname = Path.GetFileName(natlImage.FileName);
                //get image Extention
                string picextention = Path.GetExtension(picname).ToLower();

                imgErrMsg = imageproccess.CheckPic(natlImage);
                if (imgErrMsg.HasError == false)
                {
                    ViewBag.ErrorMessage = "There was a problem with uploading the image. Please try again.";
                    return View();
                }
                Random rnd = new Random();
                int imageRandomName = rnd.Next(0, 99999);
                //get image name for save in database
                string picNamedb = "/Images/" + imageRandomName.ToString() + picextention;
                //convert relative path to absolute path
                string picpath = Path.Combine(_hostingEnvironment.WebRootPath + picNamedb);

                //read stream of the image
                Bitmap bmp = new Bitmap(natlImage.OpenReadStream());
                //resize image 
                Image img = imageproccess.ResizeImage(bmp);

                //save image
                img.Save(picpath);
                //add image name and path to model
                tblNationality.Image = picNamedb;

                _context.Add(tblNationality);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Created successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(tblNationality);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblNationality = await _context.TblNationality
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblNationality == null)
            {
                return NotFound();
            }

            return View(tblNationality);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblNationality = await _context.TblNationality.FindAsync(id);

            System.IO.File.Delete(_hostingEnvironment.WebRootPath + tblNationality.Image);

            _context.TblNationality.Remove(tblNationality);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblNationalityExists(int id)
        {
            return _context.TblNationality.Any(e => e.Id == id);
        }
    }
}
