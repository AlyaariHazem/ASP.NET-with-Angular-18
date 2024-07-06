using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class Teacher
{
   public int TeacherID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly HireDate { get; set; }
    public string Gender { get; set; } = string.Empty;
    [Column(TypeName="decimal(18,2)")]
    public decimal Salary { get; set; }
    public int Phone { get; set; }
    // public DateTime SalaryPaymentDate { get; set; }=DateTime.Now;
    public string Password { get; set; } = string.Empty;
    // public int? TeacherManagedClassID { get; set; }
    // public int TeacherUserID { get; set; }
    public int ManagerID { get; set; }
    public Manager Manager { get; set; }
    public Class Class { get; set; }
    public int ClassID { get; set; }
    public ICollection<TeacherStudent> TeacherStudents { get; set; }

    // public Class ManagedClass { get; set; }
    // public User User { get; set; }
    // public IList<TeacherStudentSubject> TeacherStudentSubjects { get; set; }
    // public IList<ManagerTeacher> ManagerTeachers { get; set; }
}
