using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekGame.Models
{
    public class TblNationality
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(400)]
        public string Image { get; set; }

        /// <summary>
        /// 1=Japanese
        /// 2=Chinese
        /// 3=Korean
        /// 4=Thai
        /// </summary>
        public int Nationality { get; set; }
    }
}
