using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository.implementation.events
{
    public class EventsRepository : Repository<Event>
    {
        public EventsRepository(FourTwoCommandoContext ctx) : base(ctx)
        {
        }
    }
}