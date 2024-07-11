using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class ManagerTeacher
    {
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }
    }
}
