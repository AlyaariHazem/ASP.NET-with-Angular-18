using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Data;

public interface IAuthRepositry
{
    Task<Student> GetStudent(int id);
    Task<List<Student>> GetStudents();
    Task<
}
