namespace src.Api.Domain.Entities
{
    /// <summary>
    /// Classe responsável por atribuir propriedades para a entidade usuario.
    /// /// </summary>
    public class UserEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
