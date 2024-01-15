using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserMicroservice.Model;
using UserMicroservice.Services.Interface;

namespace UserMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> UserList()
        {
            var userList = userService.GetUserList();
            return await userList;
        }

        [HttpGet("{id}")]
        public async Task<User> GetUserById(int id)
        {
            return await userService.GetUserById(id);
        }

        [HttpPost]
        public async Task<User> AddUser(User user)
        {
            return await userService.AddUser(user);
        }

        [HttpPut]
        public async Task<User> UpdateUser(User user)
        {
            return await userService.UpdateUser(user);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteUser(int id)
        {
            return await userService.DeleteUser(id);
        }
    }
}
