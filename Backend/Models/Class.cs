using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class Class
{
    public int ClassID { get; set; }
    public string ClassName { get; set; }
    public string ClassYear { get; set; }
    public School School { get; set; }
    public int SchoolID { get; set; }
    public ICollection<Subject> Subjects { get; set; }
    public ICollection<Division> Divisions { get; set; }
}
