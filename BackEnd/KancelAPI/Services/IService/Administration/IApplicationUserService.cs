using KancelAPI.Models.Administration;

namespace KancelAPI.Services.IService.Administration
{
    public interface IApplicationUserService
    {
        Task<ApplicationUser> Login(string email, string password);
        Task<bool> Add(ApplicationUser applicationUser);
        Task<bool> UpdatePassword(Guid applicationUserId, string newPassword, string lastPassword);
    }
}
