using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Api.Domain.Interfaces.Services.User;

namespace src.Api.Application.Controllers
{
    /// <summary>
    /// Controlador responsável por ações referentes ao usuário.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Action responsável por obter todos os registros.
        /// </summary>
        /// <param name="service">Instância do serviço a ser utilizado para pesquisa.</param>
        /// <returns>Retorna um serviço com a busca de todos os registros.</returns>
        [HttpGet]
        public async Task<ActionResult> GetAll([FromServices] IUserService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
