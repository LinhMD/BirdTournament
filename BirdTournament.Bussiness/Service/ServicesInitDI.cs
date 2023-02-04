using BirdTournament.Bussiness.Service.Core;
using BirdTournament.Bussiness.Service.Implement;
using Microsoft.Extensions.DependencyInjection;

namespace BirdTournament.Bussiness.Service;

public static class ServicesInitDi
{
    public static void InitServices(
        this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUserService, UserService>();
    }
}