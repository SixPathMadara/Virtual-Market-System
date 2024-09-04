using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VIS_API.Model;

namespace VIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MarketContext _context;

        public UserController(MarketContext context)
        {
            _context = context;
        }

        //POST: api/user
       // public async Task<Users> CreateUser()

        //GET: user api/user
       // public async 
    
    }
}
