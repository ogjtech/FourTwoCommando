using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository.implementation.users
{
    public class UsersRepository : Repository<User>
    {
        public UsersRepository(FourTwoCommandoContext ctx) : base(ctx)
        {}
    }
}