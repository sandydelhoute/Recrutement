using Microsoft.Extensions.DependencyInjection;
using Recrutement.Services.Interfaces;
using Recrutement.Services.Services;

namespace Recrutement.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPokemonService, PokemonService>();
        }
    }
}
