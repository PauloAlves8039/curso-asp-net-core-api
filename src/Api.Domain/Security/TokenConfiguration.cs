namespace src.Api.Domain.Security
{
    /// <summary>
    /// Classe responsável por atribuir as propriedades de configurações do Token.
    /// </summary>
    public class TokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
