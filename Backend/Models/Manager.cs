using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }
        public Name FullName { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
        public School School { get; set; }
        public int SchoolID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

    }
}