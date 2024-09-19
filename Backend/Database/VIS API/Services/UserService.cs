using Microsoft.EntityFrameworkCore;
using VIS_API.Model;

namespace VIS_API.Services
{
    public class UserService : IUserService
    {
        private readonly MarketContext _context;

        public UserService(MarketContext context)
        {
            _context = context;
        }
        public async Task<Users> CreateUserAsync(Users user)
        {
            
            _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Users>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Users> GetUserByIDAsync(int id)
        {
            var user= await _context.Users.FindAsync(id);
            return user;
        }

        public async Task<bool> UpdateUserAsync(Users user)
        {
            _context.Entry(user).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.Users.AnyAsync(p => p.UserID == user.UserID))
                {
                    return false;
                }
                throw;
            }
        }
    }
}
