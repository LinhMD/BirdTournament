using BirdTournament.Bussiness.Service.Core;
using BirdTournament.Data.Model;
using CrudApiTemplate.Model;
using CrudApiTemplate.Repository;
using CrudApiTemplate.Services;
using CrudApiTemplate.Utilities;
using Microsoft.Extensions.Logging;

namespace BirdTournament.Bussiness.Service.Implement;

public class UserService : ServiceCrud<User>, IUserService
{
    private ILogger<UserService> _logger;
    public UserService(IUnitOfWork work, ILogger<UserService> logger) : base(work.Get<User>(), work, logger)
    {
        _logger = logger;
    }


}
