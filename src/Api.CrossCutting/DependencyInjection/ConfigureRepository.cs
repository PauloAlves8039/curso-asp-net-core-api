using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using src.Api.Data.Context;
using src.Api.Data.Implementations;
using src.Api.Data.Repository;
using src.Api.Domain.Interfaces;
using src.Api.Domain.Repository;

namespace src.Api.CrossCutting.DependencyInjection
{
    /// <summary>
    /// Classe responsável pelas configurações de injeção de dependência para repositório.
    /// </summary>
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();

            serviceCollection.AddDbContext<MyContext>(options =>
                options.UseMySql("Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=******")
            );
        }
    }
}
