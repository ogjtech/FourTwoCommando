using System;
using System.Collections.Generic;
using Data.database.models;
using Data.database.repository.abstraction;

namespace Data.database.repository
{
    public class MissionRepository : Repository<Mission>
    {
        public MissionRepository(FourTwoCommandoContext ctx) : base(ctx)
        {}
    }
}