using System.Threading.Tasks;
using src.Api.Domain.Entities;
using src.Api.Domain.Interfaces;

namespace src.Api.Domain.Repository
{
    /// <summary>
    /// Interface responsável pelos métodos de autenticação do usuário.
    /// </summary>
    public interface IUserRepository : IRepository<UserEntity>
    {
        /// <summary>
        /// Método responsável pela pesquisa de login.
        /// </summary>
        /// <param name="email">Parâmetro de pesquisa.</param>
        /// <returns>Retorna uma Task com o login pesquisado.</returns>
        Task<UserEntity> FindByLogin(string email);
    }
}
