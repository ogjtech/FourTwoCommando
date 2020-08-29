using System;

namespace Data.database.models
{
    public class Attendance
    {
        public Guid Id { get; set; }
        
        public User User { get; set; }

        public Event Event { get; set; }
        
        public bool Attending { get; set; }
    }
}