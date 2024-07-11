using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Data;

public interface IAuthRepositry
{
    Task<User> register(User user,string password);
    Task<User> Login(string username,string password);
    
}
