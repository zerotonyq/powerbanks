using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PP.Infrastucture.PowerBankRepository;
using PP.Infrastucture.PowerStationRepository;
using PP.Infrastucture.UserRepository;

namespace PP.Infrastucture;

public static class InfrastructureInjection
{
    public static IServiceCollection Configure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IPowerBankRepository, PowerBankRepository.PowerBankRepository>();
        services.AddSingleton<IPowerStationRepository, PowerStationRepository.PowerStationRepository>();
        services.AddSingleton<IUserRepository, UserRepository.UserRepository>();
        return services;
    }
}