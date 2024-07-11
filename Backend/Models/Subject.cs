using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
 public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
        public ICollection<SubjectStudent> SubjectStudents { get; set; }
        public ICollection<TeacherSubjectStudent> TeacherSubjectStudents { get; set; }
    }
    }