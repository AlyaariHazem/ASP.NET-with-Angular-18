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
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        public virtual ICollection<StudentClass> StudentClass { get; set; }
    }
}
