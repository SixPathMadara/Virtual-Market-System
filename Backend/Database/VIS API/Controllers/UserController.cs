using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VIS_API.Model;
using VIS_API.Services;

namespace VIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userContext)
        {
            _userService = userContext;
        }

        //POST: api/user
        [HttpPost]
        public async Task<ActionResult<Users>> CreateUser([FromBody] Users user)
        {
            var CreatedUser = await _userService.CreateUserAsync(user);
            return CreatedAtAction(nameof(GetUser), new { id = CreatedUser.UserID });
        }

        //GET : api/user
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }
        //GET: user api/user/{userID}
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            var user = await _userService.GetUserByIDAsync(id);
            if (user == null)
            {
                return BadRequest(NotFound());
            }
            return Ok(user);
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public async Task<IUserService> UpdateUser(int id, [FromBody] Users updatedUser)
        {
            if (id != updatedUser.UserID)
            {
                return (IUserService)BadRequest();
            }
            var isUpdated = await _userService.UpdateUserAsync(updatedUser);
            if (!isUpdated)
            {
                return (IUserService)NotFound();
            }
            return (IUserService)NoContent();
        }
    }
}
