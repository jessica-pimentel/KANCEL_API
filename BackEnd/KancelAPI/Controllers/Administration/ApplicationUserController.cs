using KancelAPI.Controller.Grobal;
using KancelAPI.Models.Administration;
using KancelAPI.Services.IService.Administration;
using Microsoft.AspNetCore.Mvc;

namespace KancelAPI.Controller.Administration
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ApplicationUserController : BaseController
    {
        private readonly IApplicationUserService _applicationUserService;
        public ApplicationUserController(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(string email, string password)
        {
            var r = await _applicationUserService.Login(email, password);

            if (r != null) return CustomResponse(r);

            return CustomResponseError("Email ou senha errados, tente novamente!");
            
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(ApplicationUser obj)
        {
            var r = await _applicationUserService.Add(obj);

            if (r) return CustomResponse("Cadastrado com sucesso, efetue Login!");

            return CustomResponseError("Erro ao se cadastrar, tente novamente!");

        }

        [HttpPut("updatePassword")]
        public async Task<ActionResult> UpdatePassword(Guid applicationUserId, string newPassword, string lastPassword)
        {
            var r = await _applicationUserService.UpdatePassword(applicationUserId, newPassword, lastPassword);

            if (r) return CustomResponse("Senha atualizada com sucesso!");

            return CustomResponseError("Erro ao atualizar senha, tente novamente!");
        }
    }
}
