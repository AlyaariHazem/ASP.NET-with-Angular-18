using System.Threading.Tasks;
using Backend.DTOS;
using Backend.Models;
namespace Backend.Data
{
    public interface IAuthRepositry
    {
        Task<User> Register(User NewStudent, string password, string userType);
        Task<Student> CreateStudent(Student NewStudent);
        Task<User?> Login(string userName, string password, string userType);
        Task<bool> UserExists(string userName, string userType);
         Task<bool> RefranceExist(string Refrance, int ID);
    }
}
