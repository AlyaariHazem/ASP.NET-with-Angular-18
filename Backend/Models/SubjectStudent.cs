using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class SubjectStudent
{
    public int SubjectID { get; set; }
    public Subject Subject { get; set; } 
    public int Grade { get; set; }   
    public int StudentID { get; set; }
    public Student Student { get; set; }
}
