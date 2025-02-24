using mhcb.Syd.Models.Account;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services.Identity
{
    public interface IAccountHttpService
    {
        public Task<string> SignInAsync(LoginInput user);
        public Task<string> RegisterAsync(RegisterInput user);

        // 1.
        public Task<IdentityUser> FindByEmailAsync(string email);
        public Task<IdentityUser> FindByNameAsync(string userName);
        public Task<IdentityUser> FindByIdAsync(string userId);

        // 2.
        public Task<string> GetUserIdByNameAsync(string userName);
        public Task<string> GetUserIdByEmailAsync(string email);

        // 3.
        public Task<bool> IsEmailConfirmedByNameAsync(string userName);
        public Task<bool> IsEmailConfirmedByEmailAsync(string email);

        // 4. get token
        public Task<string> GenerateEmailConfirmationTokenAsync(string email);
        public Task<string> GeneratePasswordResetTokenAsync(string userName);

        // 5. Reset Password
        public Task<string> ResetPasswordByNameAsync(string userName, string newPassword);
        public Task<string> ResetPasswordByEmailAsync(string email, string newPassword);

        // 6. Confirm email
        public Task<string> ConfirmEmailAsync(string email);

    }
}
