using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntAppSecond.Model
{
    public class Student
    {
            [Display(Name = "Student ID")]
            [RegularExpression(@"^[sS][0-9]{8}$")]
            [StringLength(9)]
            [Required(ErrorMessage = "Please enter a student ID")]
            public string StudentID { get; set; } = "";


            [Display(Name = "First Name")]
            [StringLength(30,MinimumLength =2)]
            [Required]
            public string FirstName { get; set; } = "";


            [Display(Name = "Surname")]
            [StringLength(30,MinimumLength =3)]
            [Required]
            public string LastName { get; set; } = "";


            [DataType(DataType.Date)]
            [Display(Name = "Date of Birth")]
            [Required]
            public string DOB { get; set; } 


            [Display(Name = "Number of Modules")]
            [Required]
            public int NumberOfModules { get; set; }


            [Display(Name = "Height(cm)")]
            [Required]
            public int HeightInCM { get; set; }


            [DataType(DataType.EmailAddress)]
            [Display(Name = "Email Address")]
            [Required]
            public string Email { get; set; }


            [DataType(DataType.EmailAddress)]
            [Display(Name ="Confirm Email Address")]
            [Required]
            public string EmailConfirm { get; set; }

    }
}
