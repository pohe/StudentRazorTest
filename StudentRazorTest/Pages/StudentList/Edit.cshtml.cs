using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorTest.Model;

namespace StudentRazorTest.Pages.StudentList
{
    public class EditModel : PageModel
    {
        
        public EditModel()
        {
        }

        [BindProperty]
        public Student Student { get; set; }

        public void OnGet(int id)
        {
            Student = StudentCatalogSingleton.Instance.FindStudent(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Student oldStudent = StudentCatalogSingleton.Instance.FindStudent(Student.No);
                oldStudent.No = Student.No;
                oldStudent.Name = Student.Name;
                oldStudent.Address = Student.Address;
                
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}