
using BirdTournament.Data.Model;
using BirdTournament.Data.Repository.Core;
using BirdTournament.Data.Repository.Implement;
using CrudApiTemplate.Repository;
using Microsoft.EntityFrameworkCore;

namespace BirdTournament.Data.Repository;

public class BirdTournamentUnitOfWork : UnitOfWork
{
    private readonly BirdTournamentDataContext _dataContext;
    public BirdTournamentUnitOfWork(BirdTournamentDataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
        Add(new UserRepository(dataContext));
    }

    public IUserRepository Users => (IUserRepository)Get<User>();
}