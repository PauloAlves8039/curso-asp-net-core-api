using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using src.Api.Domain.Entities;

namespace src.Api.Domain.Interfaces.Services.User
{
    /// <summary>
    /// Interface responsável pelos métodos referentes a regra de negócio da aplicação.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Método assíncrono para pesquisar registro por id.
        /// </summary>
        /// <param name="id">Parâmetro de pesquisa de resgistro.</param>
        /// <returns>Uma Task com registro buscado por id.</returns>
        Task<UserEntity> Get(Guid id);

        /// <summary>
        /// Método assíncrono para pesquisar todos os registros.
        /// </summary>
        /// <returns>Retorna uma Task com uma coleção de registros.</returns>            
        Task<IEnumerable<UserEntity>> GetAll();

        /// <summary>
        /// Método assíncrono para adicionar registro.
        /// </summary>
        /// <param name="user">Define uma entidade a ser adicionada.</param>
        /// <returns>Uma Task com registro adicionando.</returns>
        Task<UserEntity> Post(UserEntity user);

        /// <summary>
        /// Método assíncrono para atualizar registro.
        /// </summary>
        /// <param name="user">Define uma entidade a ser atualizada.</param>
        /// <returns>Uma Task com registro atualizado.</returns>
        Task<UserEntity> Put(UserEntity user);

        /// <summary>
        /// Método assíncrono para exlcuir registro por id.
        /// </summary>
        /// <param name="id">Define uma entidade a ser excluída.</param>
        /// <returns>Uma Task com registro excluído.</returns>
        Task<bool> Delete(Guid id);
    }
}
