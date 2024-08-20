using KancelAPI.Interfaces.Repository.Administration;
using KancelAPI.Models.Administration;
using KancelAPI.Services.IService.Administration;

namespace KancelAPI.Services.Service.Administration
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public ApplicationUserService(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }

        public async Task<ApplicationUser> Login(string email, string password)
        {
            return await _applicationUserRepository.Login(email, password);
        }

        public async Task<bool> Add(ApplicationUser applicationUser)
        {
            await _applicationUserRepository.Add(applicationUser);
            return true;
        }

        public async Task<bool> UpdatePassword(Guid ApplicationUserId, string newPassword, string lastPassword)
        {
            await _applicationUserRepository.UpdatePassword(ApplicationUserId, newPassword, lastPassword);
            return true;
        }
    }
}
