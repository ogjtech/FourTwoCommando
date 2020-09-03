using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository.implementation.ranks
{
    public class RanksRepository : Repository<Rank>
    {
        public RanksRepository(FourTwoCommandoContext ctx) : base(ctx)
        {}
    }
}