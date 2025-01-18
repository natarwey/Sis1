using Microsoft.AspNetCore.Mvc;
using Sis1.Interfaces;
using Sis1.Requests;
using Sis1.Service;

namespace Sis1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersLoginsController
    {
        private readonly IUsersLoginsService _userLoginService;

        public UsersLoginsController(IUsersLoginsService usersLoginsService)
        {
            _userLoginService = usersLoginsService;
        }

        [HttpGet]
        [Route("getAllUser")]
        public async Task<IActionResult> GetAllUsers()
        {
            return await _userLoginService.GetAllUsersAsync();
        }

        [HttpPost]
        [Route("createNewUserAndLogin")]
        public async Task<IActionResult> CreateNewUserAndLogin(CreateNewUserAndLogin data)
        {
            return await _userLoginService.CreateNewUserAndLoginAsync(data);
        }
    }
}
