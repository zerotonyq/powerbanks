using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerBanks.Queries.Search;

namespace PP.Application;

public static class ApplicationInjection
{
    public static IServiceCollection Configure(
        this IServiceCollection services, IConfiguration configuration)
    {

        services.AddSingleton<GetPowerBankHandler>();
        services.AddMediatR(cfg
            => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        
        return services;
    }
}