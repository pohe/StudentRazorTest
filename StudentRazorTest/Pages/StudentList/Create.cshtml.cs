using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorTest.Model;

namespace StudentRazorTest.Pages.StudentList
{
    public class CreateModel : PageModel
    {
        public List<Student> Students { get; set; }
        public CreateModel()
        {
            Students = StudentCatalogSingleton.Instance.Students;
        }

        [BindProperty]
        public Student Student { get; set; }
        public void OnGet()
        {

        }

        public  IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Students.Add(Student);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }

    }
}