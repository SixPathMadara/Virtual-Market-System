using System.Collections.Generic;
using System.Threading.Tasks;
using VIS_API.Model;

namespace VIS_API.Services
{
    public interface IUserService
    {
        Task<Users> CreateUserAsync(Users user);
        Task<Users> GetUserByIDAsync(int id);
        Task<bool> UpdateUserAsync(Users user);
        Task<bool> DeleteUserAsync(int id);
    }
}
