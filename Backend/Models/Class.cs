using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassYear { get; set; }
        public int PhaseID { get; set; }
        [JsonIgnore]
        public Phase Phase { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Division> Divisions { get; set; }
        public ICollection<StudentClass> StudentClass { get; set; }
    }
}
