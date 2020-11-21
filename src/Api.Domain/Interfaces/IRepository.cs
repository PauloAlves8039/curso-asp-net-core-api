using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using src.Api.Domain.Entities;

namespace src.Api.Domain.Interfaces
{
    /// <summary>
    /// Interface responsável pela implemetação padrão de propriedades para qualquer tipo de entidade.
    /// </summary>
    /// <typeparam name="T">Define um parâmetro genérico.</typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Método assíncrono para inserir registro.
        /// </summary>
        /// <param name="item">Recebe um tipo genérico.</param>
        /// <returns>Retorna uma Task referente a um tipo genérico.</returns>
        Task<T> InsertAsync(T item);

        /// <summary>
        /// Método assíncrono para atualizar registro.
        /// </summary>
        /// <param name="item">Recebe um tipo genérico.</param>
        /// <returns>Retorna uma Task referente a um tipo genérico.</returns>
        Task<T> UpdateAsync(T item);

        /// <summary>
        /// Método assíncrono para excluir registro.
        /// </summary>
        /// <param name="id">Recebe um identificador para exclusão.</param>
        /// <returns>Retorna uma Task referente a um tipo boleano.</returns>
        Task<bool> DeleteAsync(Guid id);

        /// <summary>
        /// Método assíncrono para selecionar registro por id.
        /// </summary>
        /// <param name="id">Recebe um identificador para seleção.</param>
        /// <returns>Retorna uma Task referente a um tipo genérico.</returns>
        Task<T> SelectAsync(Guid id);

        /// <summary>
        /// Método assíncrono para selecionar todos os registros.
        /// </summary>
        /// <returns>Retorna uma Task referente a uma coleção com tipo genérico.</returns>
        Task<IEnumerable<T>> SelectAsync();

        /// <summary>
        /// Método assíncrono para verificar a existência de registro por id.
        /// </summary>
        /// <param name="id">Recebe um identificador para verificação.</param>
        /// <returns>Retorna uma Task referente a um tipo genérico.</returns>
        Task<bool> ExistAsync(Guid id);
    }
}
