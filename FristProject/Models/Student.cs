using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FristProject.Models
{
    public class Student
    {   
        [Required(ErrorMessage  = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        public Int32 Phone { get; set; }


        [Required(ErrorMessage = "Please choose if you are graduated or not")]

        public bool? hasGraduate { get; set; }

    }
}
