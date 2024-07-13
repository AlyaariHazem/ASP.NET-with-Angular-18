using System.Threading.Tasks;
using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Backend.DTOS;

namespace Backend.Data
{
    public class AuthRepository : IAuthRepositry
    {
        private readonly DatabaseContext _context;

        public AuthRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<User?> Login(string userName, string password, string userType)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == userName && x.UserType == userType);
            if (user == null) return null;
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;
            return user;
        }
        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public async Task<User> Register(User user, string password, string userType)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(); // Save changes to get the UserID

            return user;
        }
        public async Task<Student> CreateStudent(Student NewStudent)
        {

            await _context.Students.AddAsync(NewStudent);
            await _context.SaveChangesAsync(); // Save changes to get the UserID
            return NewStudent;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string userName, string userType)
        {
            return await _context.Users.AnyAsync(x => x.UserName == userName && x.UserType == userType);
        }
        public async Task<bool> RefranceExist(string Refrance, int ID)
        {
            Refrance.ToLower();
            switch (Refrance)
            {
                case "division":
                    return await _context.Divisions.AnyAsync(x => x.DivisionID == ID);

                case "guardian":
                    return await _context.Guardians.AnyAsync(x => x.GuardianID == ID);

                default:
                return false;
            }

        }
    }
}
