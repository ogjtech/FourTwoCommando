using Data.database.models;
using Microsoft.EntityFrameworkCore;

namespace Data.database
{
    public class FourTwoCommandoContext : DbContext
    {
        public FourTwoCommandoContext(DbContextOptions<FourTwoCommandoContext> options) : base(options)
        { }
        
        public DbSet<User> Users { get; set; }
        
        public DbSet<Role> Roles { get; set; }
        
        public DbSet<Rank> Ranks { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<Event> Events { get; set; }
        
        public DbSet<Attendance> Attendances { get; set; }
    }
}