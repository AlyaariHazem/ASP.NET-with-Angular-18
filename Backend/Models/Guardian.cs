using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
public class Guardian
{
    public int GuardianID { get; set; }
    public Name FullName { get; set; } 
    public string Phone { get; set; }
    public string Password { get; set; }
    public string Job { get; set; }
    public string TypeGuardian { get; set; }
    public string Description { get; set; }
    public ICollection<Student> Students { get; set; }
}
}