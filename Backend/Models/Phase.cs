using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
public class Phase
{
    public int PhaseID { get; set; }
    public string PhaseName { get; set; }
    public string? Note { get; set; }
    public bool Active { get; set; }
    public DateTime HireDate { get; set; }
    public int YearID { get; set; }
    public Year Year { get; set; }
    public ICollection<Class> Classes { get; set; }
    
 }   
}
