using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Api.Domain.Entities;
using src.Api.Domain.Interfaces.Services.User;

namespace src.Api.Application.Controllers
{
    /// <summary>
    /// Controlador responsável pelas ações referentes ao login do usuário.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        /// <summary>
        /// Método responsável pelo login do usuário.
        /// </summary>
        /// <param name="userEntity">Parâmetro para representar o UserEntity.</param>
        /// <param name="service">Parâmetro para representar o serviço do usuário.</param>
        /// <returns>O estado da requisição do usuário.</returns>
        [HttpPost]
        public async Task<object> Login([FromBody] UserEntity userEntity, [FromServices] ILoginService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (userEntity == null)
            {
                return BadRequest();
            }

            try
            {
                var result = await service.FindByLogin(userEntity);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
