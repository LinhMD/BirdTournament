using BirdTournament.Data.Model;
using BirdTournament.Data.Repository.Core;
using CrudApiTemplate.Repository;
using Microsoft.EntityFrameworkCore;

namespace BirdTournament.Data.Repository.Implement;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
    }
}
