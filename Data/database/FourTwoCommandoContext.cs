using System;
using Data.database.models;
using Microsoft.EntityFrameworkCore;

namespace Data.database
{
    public class FourTwoCommandoContext : DbContext
    {
        public FourTwoCommandoContext(DbContextOptions<FourTwoCommandoContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Role adminRole = new Role() { Id = Guid.NewGuid(), Name = "Admin" };
            Role memberRole = new Role() { Id = Guid.NewGuid(), Name = "Member" };
            
            modelBuilder.Entity<Role>().HasData(
                adminRole,
                new Role { Id = Guid.NewGuid(), Name = "Newbie" },
                memberRole,
                new Role { Id = Guid.NewGuid(), Name = "Recruiter" }
            );

            Rank ltRank = new Rank() { Id = Guid.NewGuid(), Abbreviation = "Lt.", Title = "Lieutenant" };
            Rank marineRank = new Rank() { Id = Guid.NewGuid(), Abbreviation = "Mne.", Title = "Marine" };

            modelBuilder.Entity<Rank>().HasData(
                ltRank,
                marineRank,
                new Rank { Id = Guid.NewGuid(), Abbreviation = "Rct.", Title = "Recruit" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Password = "123", Rank = ltRank, Roles = new Role[] { adminRole, memberRole }, Username = "unsworth" },
                new User { Id = Guid.NewGuid(), Password = "152", Rank = marineRank, Roles = new Role[] { memberRole }, Username = "tech" }
                );
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Role> Roles { get; set; }
        
        public DbSet<Rank> Ranks { get; set; }
        
        public DbSet<Mission> Missions { get; set; }
        
        public DbSet<Event> Events { get; set; }
        
        public DbSet<Attendance> Attendances { get; set; }
    }
}