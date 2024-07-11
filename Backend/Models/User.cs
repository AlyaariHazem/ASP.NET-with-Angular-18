using System;
using System.Collections.Generic;

namespace Backend.Models
{
    public class User
    {
        public int UserID { get; set; }
        public Name FullName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public string UserType { get; set; }

     // Navigation properties for specific user roles
        public Guardian Guardian { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public Manager Manager { get; set; }
    }
}