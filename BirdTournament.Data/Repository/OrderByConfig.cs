using BirdTournament.Data.Model;
using Microsoft.Extensions.DependencyInjection;

namespace BirdTournament.Data.Repository;

public static class OrderByConfig
{
    public static void ConfigOrderBy(this IServiceCollection serviceCollection)
    {
        new User().ConfigOrderBy();
    }
}