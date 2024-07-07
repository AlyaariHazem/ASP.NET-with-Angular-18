using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models;

public class Manager
{
    public int ManagerID { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Phone { get; set; }
    public int Age { get; set; }
    public School School { get; set; }
    public ICollection<Teacher> Teachers { get; set; }

}
