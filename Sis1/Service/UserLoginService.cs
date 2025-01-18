using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sis1.DataBaseContext;
using Sis1.Interfaces;
using Sis1.Model;
using Sis1.Requests;

namespace Sis1.Service
{
    public class UserLoginService : IUsersLoginsService
    {
        private readonly ContextDB _context;

        public UserLoginService(ContextDB context)
        {
            _context = context;
        }

        public async Task<IActionResult> CreateNewUserAndLoginAsync(CreateNewUserAndLogin data)
        {
            var user = new Users()
            {
                Name = data.Name,
                Email = data.Email
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            var login = new Logins()
            {
                User_id = user.id_User,
                Login = data.Login,
                Password = data.Password,
            };

            await _context.Logins.AddAsync(login);
            await _context.SaveChangesAsync();

            return new OkObjectResult(new
            {
                status = true
            });
        }

        public async Task<IActionResult> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();

            return new OkObjectResult(new 
            {
                data = users,
                status = true
            });
        }
    }
}
