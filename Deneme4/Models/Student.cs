using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme4.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Type ur Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Type ur Surname")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Type ur Email")]
        public string email { get; set; }
        [Required(ErrorMessage ="Type ur Phone Number")]
        public string telefon { get; set; }
        public string STGraphicscard { get; set; }
        public string STMainboard { get; set; }
        public string STRam { get; set; }
        public string STMonitor { get; set; }

        
      
    }
}
