using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Student
    {
        [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int Grade { get; set; }
        public int Phone { get; set; }
        public string DivisionName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Appreciation { get; set; }
        public int DivisionID { get; set; }
        public int GuardianID { get; set; }
        public Guardian Guardian { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<SubjectStudent> SubjectStudents { get; set; }
        public Division Division { get; set; }
    }
}
