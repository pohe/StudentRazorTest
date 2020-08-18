using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorTest.Model
{
    public class StudentCatalogSingleton
    {
        private static StudentCatalogSingleton instance;

        public static StudentCatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentCatalogSingleton();
                return instance;
            }
        }

        public List<Student> Students { get; set; }

        public  Student FindStudent(int no)
        {
            foreach (Student s in Students)
            {
                if (s.No == no)
                {
                    return s; 
                }
            }

            return null; 
        }

        internal void DeleteStudent(Student studentToDelete)
        {
            Students.Remove(studentToDelete);
        }

        private StudentCatalogSingleton()
        {
            Students = new List<Student>();

            Students.Add(new Student(1, "Charlotte", 1903, "Bakken 1", "chhe@easj.dk"));
            Students.Add(new Student(2, "Peter", 2003, "Gade 112", "pele@easj.dk"));
            Students.Add(new Student(3, "Micheal", 1963, "Vej 112", "micl@easj.dk"));
        }


    }
}
