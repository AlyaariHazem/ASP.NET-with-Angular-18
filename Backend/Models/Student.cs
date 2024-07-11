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
        public int StudentID { get; set; }
        public Name FullName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        // Calculated Rate property
        public int Rate
        {
            get
            {
                if (SubjectStudents.Any())
                {
                    return (int)SubjectStudents.Average(ss => ss.Grade);
                }
                return 0;
            }
        }

        public int? Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        // Calculated Appreciation property
        public string Appreciation
        {
            get
            {
                if (Rate >= 90)
                {
                    return "Excellent";
                }
                else if (Rate >= 80)
                {
                    return "Very Good";
                }
                else if (Rate >= 50)
                {
                    return "Good";
                }
                else
                {
                    return "Failed";
                }
            }
        }

        public int GuardianID { get; set; }
        public Guardian Guardian { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<TeacherStudent> TeacherStudents { get; set; }
        public ICollection<SubjectStudent> SubjectStudents { get; set; }
        public int DivisionID { get; set; }
        public Division Division { get; set; }
        public ICollection<TeacherSubjectStudent> TeacherSubjectStudents { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
    }
}