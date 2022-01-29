    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme4.Models
{
    public class Computer
    {
        [Key]
        public int Pcid { get; set; }
        //[Required(ErrorMessage = "Type ur  Name")]
        //public string StudentName { get; set; }
        [Required(ErrorMessage = "Type ur Graphics Card's Name")]
        public string Graphicscard { get; set; }
        [Required(ErrorMessage = "Type ur Mainbord's Name ")]
        public string Mainboard { get; set; }
        [Required(ErrorMessage ="Type ur RAM's memory")]
        public string Ram { get; set; }
        [Required(ErrorMessage ="Type ur Monitor's Name")]
        public string Monitor { get; set; }

    }
}
