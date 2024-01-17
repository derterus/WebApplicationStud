using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string SecondName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Height { get; set; }
        public string BirthDay { get; set; }
        public string Group { get; set; }
        public string Speciality { get; set; }
        public int Scholarship { get; set; }
    }
}
