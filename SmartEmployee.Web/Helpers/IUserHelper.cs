using Microsoft.AspNetCore.Identity;
using SmartEmployee.Web.Data.Entities;
using SmartEmployee.Web.Models;
using System.Threading.Tasks;

namespace SmartEmployee.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        string CreateRandomPassword(int PasswordLength);
    }
}
