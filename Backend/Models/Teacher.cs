using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Backend.Models
{
  public class Teacher
    {
       
        public int TeacherID { get; set; }
        public Name FullName { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int? Age { get; set; }
        public DateOnly HireDate { get; set; }
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<Salary> Salaries { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<TeacherSubjectStudent> TeacherSubjectStudents { get; set; }
    }
}