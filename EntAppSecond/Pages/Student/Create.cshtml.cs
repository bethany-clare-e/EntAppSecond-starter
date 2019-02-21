using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.stud
{
    public class CreateModel : PageModel
    {
        [BindProperty]

        public Model.Student Student { get; set; }
        public void OnGet()
        {


        }

        public void OnPost()
        {
            if (Student.NumberOfModules <= 1)
            {
                ModelState.AddModelError("Student.NumberOfModules", "You must take more than 1 module");
            }

            if (Student.HeightInCM < 50 || Student.HeightInCM >= 250)
            {
                ModelState.AddModelError("Student.HeightInCM", "Height must be < 50 cm and > 250cm");
                    
            }

            if (Student.Email != Student.EmailConfirm)
            {
                ModelState.AddModelError("Student.Email", "Emails don't match");
            }
        }
    }
}