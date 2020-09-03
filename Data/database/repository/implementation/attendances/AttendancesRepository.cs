using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository.implementation.attendances
{
    public class AttendancesRepository : Repository<Attendance>
    {
        public AttendancesRepository(FourTwoCommandoContext ctx) : base(ctx)
        {
        }
    }
}