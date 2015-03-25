using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment9.Models
{
    public class Blog
    {
        public string Past { get; set; }
        public string Past1 { get; set; }
        public string Past2 { get; set; }
        public string Past3 { get; set; }
        public string Past4 { get; set; }
        [Required]
        public int BlogID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string About { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Favorite { get; set; }
        [Required]
        public string Last { get; set; }
        [Required]
        public string Date { get; set; }
    }
}
