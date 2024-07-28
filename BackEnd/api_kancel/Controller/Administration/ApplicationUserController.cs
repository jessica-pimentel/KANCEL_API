using domain_kancel.Interfaces.Repository.Administration;
using domain_kancel.Models.Administration;
using domain_kancel.Service;
using Microsoft.AspNetCore.Mvc;

namespace api_kancel.Controller.Administration
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ApplicationUserController : ControllerBase
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

            if (r != null) return Ok(r);

            return BadRequest("Email ou senha errados, tente novamente!");
            
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register(ApplicationUser obj)
        {
            var r = await _applicationUserService.Add(obj);

            if (r) return Ok("Cadastrado com sucesso, efetue Login!");

            return BadRequest("Erro ao se cadastrar, tente novamente!");

        }

        [HttpPut("updatePassword")]
        public async Task<ActionResult> UpdatePassword(Guid applicationUserId, string newPassword, string lastPassword)
        {
            var r = await _applicationUserService.UpdatePassword(applicationUserId, newPassword, lastPassword);

            if (r) return Ok("Senha atualizada com sucesso!");

            return BadRequest("Erro ao atualizar senha, tente novamente!");
        }
    }
}
