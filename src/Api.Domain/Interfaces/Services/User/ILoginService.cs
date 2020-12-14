using System.Threading.Tasks;
using src.Api.Domain.Dtos;

namespace src.Api.Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        /// <summary>
        /// Método responsável pela pesquisa de login do usuário.
        /// </summary>
        /// <param name="user">Parâmetro de pesquisa.</param>
        /// <returns>Retorna uma Task com o login do usuário pesquisado.</returns>
        Task<object> FindByLogin(LoginDto user);
    }
}
