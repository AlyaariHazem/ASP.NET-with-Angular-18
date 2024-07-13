using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.DTOS;

public class UserForLoginDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
}
