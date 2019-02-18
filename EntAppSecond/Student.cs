using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntAppSecond
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter a student ID")]
        public string StudentID { get; set; } = "";
        [Required]
        public string FirstName { get; set; } = "";
        //[Display(Name = "First Name")]
        [Required]
        public string LastName { get; set; } = "";
    }
}

