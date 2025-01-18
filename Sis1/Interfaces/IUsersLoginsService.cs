using Microsoft.AspNetCore.Mvc;
using Sis1.Requests;

namespace Sis1.Interfaces
{
    public interface IUsersLoginsService
    {
        Task<IActionResult> GetAllUsersAsync();
        Task<IActionResult> CreateNewUserAndLoginAsync(CreateNewUserAndLogin data);
    }
}
