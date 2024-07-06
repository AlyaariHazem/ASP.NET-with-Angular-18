using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class Division
{
     public int DivisionID { get; set; }
    public string DivisionName { get; set; } = string.Empty;
    public int ClassID { get; set; }
    public Class Class { get; set; }
    public ICollection<Student> Students { get; set; }
}
