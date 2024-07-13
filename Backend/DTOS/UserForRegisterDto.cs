using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Backend.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserType { get; set; }
        public string Password { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string userName { get; set; }
    }
}
