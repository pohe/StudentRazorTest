using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorTest.Model;

namespace StudentRazorTest.Pages.StudentList
{
    public class IndexModel : PageModel
    {
        public StudentCatalogSingleton TheStudentCatalogSingleton { get; set; }
        public  IndexModel()
        {
            TheStudentCatalogSingleton = StudentCatalogSingleton.Instance;
        }

        public IActionResult OnPostDelete(int id)
        {
            Student studentToDelete = TheStudentCatalogSingleton.FindStudent(id);
            if (studentToDelete == null)
            {
                return NotFound();
            }

            TheStudentCatalogSingleton.DeleteStudent(studentToDelete);

            return RedirectToPage("Index");
        }

    }
}