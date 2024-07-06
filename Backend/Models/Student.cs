using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Student
    {
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
        public int DivisionID { get; set; }
        public int GuardianID { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
        public Guardian Guardian { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<SubjectStudent> SubjectStudents { get; set; }
        public Division Division { get; set; }

        public string Appreciation
        {
            get
            {
                if (Grade > 90) return "Excellent";
                if (Grade > 80) return "Very Good";
                if (Grade > 50) return "Good";
                return "Failure";
            }
        }
    }
}
