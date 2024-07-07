using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Backend.Models;

public class Teacher
{
     [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
    // public int TeacherUserID { get; set; }
    public int ManagerID { get; set; }
    public Manager Manager { get; set; }
    public ICollection<TeacherStudent> TeacherStudents { get; set; }

}
