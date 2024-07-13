using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Dtos;
using Backend.DTOS;
using Backend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepositry _repo;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepositry repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterStudent registerStudent)
        {
            //validate fi the user exisit 
            if (await _repo.UserExists(registerStudent.UserName, registerStudent.UserType))
                return BadRequest("User already exists");

            //validation for divisionId and guardainId in student
            if (await _repo.RefranceExist("division", registerStudent.DivisionID) == false)
                return BadRequest("the Division is not exist ");
            if (await _repo.RefranceExist("guardian", registerStudent.GuardianID) == false)
                return BadRequest("the Guardain is not exist ");
            var userToCreate = new User
            {
                UserName = registerStudent.UserName,
                UserType = registerStudent.UserType,
                CreatedAt = registerStudent.CreatedAt,
                UpdatedAt = registerStudent.UpdatedAt
            };

            // Register the user and save changes to get the UserID
            var createdUser = await _repo.Register(userToCreate, registerStudent.Password, registerStudent.UserType);

            // Assign the UserID to the student
            var studentToCreate = new Student
            {
                FullName = new Name
                {
                    FirstName = registerStudent.FirstName,
                    SecondName = registerStudent.SecondName,
                    ThirdName = registerStudent.ThirdName,
                    LastName = registerStudent.LastName
                },
                DateOfBirth = registerStudent.DateOfBirth,
                Gender = registerStudent.Gender,
                Phone = registerStudent.Phone,
                GuardianID = registerStudent.GuardianID,
                DivisionID = registerStudent.DivisionID,
                UserID = createdUser.UserID, // Assign the UserID from the created user
            };

            // Create the student and save changes
            var createdStudent = await _repo.CreateStudent(studentToCreate);

            return Ok(createdStudent); // Created
        }

        [HttpPost("login")]
        public async Task<IActionResult> login(UserForLoginDto userForLoginDto)
        {
            var userFromReop = await _repo.Login(userForLoginDto.UserName.ToLower(), userForLoginDto.Password, userForLoginDto.UserType.ToLower());
            if (userFromReop == null) return Unauthorized();

            var claims = new[]
            {
        new Claim(ClaimTypes.NameIdentifier, userFromReop.UserID.ToString()),
        new Claim(ClaimTypes.Name, userFromReop.UserName)
    };

            var tokenValue = _config.GetSection("AppSettings:Token").Value;

            if (string.IsNullOrEmpty(tokenValue))
            {
                // Handle the case where the token value is null or empty
                return StatusCode(StatusCodes.Status500InternalServerError, "Token configuration is missing.");
            }

            if (tokenValue.Length < 16)
            {
                // Ensure the key is at least 128 bits
                return StatusCode(StatusCodes.Status500InternalServerError, "Token key is too short. Must be at least 128 bits.");
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenValue));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}
