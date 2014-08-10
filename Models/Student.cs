using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Student
    {

         public int RollNbr { get; set; }

        [Required]
        public string FirstName { get; set; }

        public int? Class { get; set; }
        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Friends { get; set; }


    }
}