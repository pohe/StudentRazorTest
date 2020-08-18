using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRazorTest.Model
{
    public class Student
    {
        [Required]
        
        public int No { get; set; }
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public Student()
        {

        }

        public Student(int no, string name, int yearOfBirth, string address, string email)
        {
            No = no;
            Name = name;
            YearOfBirth = yearOfBirth;
            Address = address;
            Email = email;
        }

        public override string ToString()
        {
            return $"Studentno {No} name {Name} born {YearOfBirth} som bor {Address} email {Email}";
        }
    }
}
