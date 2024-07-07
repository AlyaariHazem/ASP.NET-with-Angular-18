using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class School
{
    public int SchoolID { get; set; }
    public string SchoolName { get; set; }
    public string Notes { get; set; }
    public string SchoolLocation { get; set; }
    public ICollection<Class> Classes { get; set; }
    public Manager Manager { get; set; }
    public int ManagerID { get; set; }
    
}