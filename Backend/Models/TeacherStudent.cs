using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class TeacherStudent
{
    public int StudentID { get; set; }
    public Student Student { get; set; }
    public int TeacherID { get; set; }
    public Teacher Teacher { get; set; }
}
