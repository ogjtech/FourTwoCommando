using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository.implementation.roles
{
    public class RolesRepository : Repository<Role>
    {
        public RolesRepository(FourTwoCommandoContext ctx) : base(ctx)
        {
        }
    }
}