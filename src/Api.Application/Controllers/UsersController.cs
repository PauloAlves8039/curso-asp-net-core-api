using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.Api.Domain.Entities;
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
        private IUserService _service;

        public UsersController(IUserService service)
        {
            _service = service;
        }

        /// <summary>
        /// Action responsável por obter todos os registros.
        /// </summary>
        /// <param name="service">Instância do serviço a ser utilizado para pesquisa.</param>
        /// <returns>Retorna um serviço com a busca de todos os registros.</returns>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Action responsável por obter registro por id.
        /// </summary>
        /// <param name="id">Parâmetro de pesquisa de registro.</param>
        /// <returns>Retorna um serviço com a busca de um registro.</returns>
        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Action responsável por adicionar registro.
        /// </summary>
        /// <param name="user">Objeto a ser adicionado.</param>
        /// <returns>Retorna um serviço com um registro adicionado.</returns>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(user);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Action responsável por atualizar registro.
        /// </summary>
        /// <param name="user">Objeto a ser atualizado</param>
        /// <returns>Retorna um serviço com um registro atualizado.</returns>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UserEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(user);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

    }
}
