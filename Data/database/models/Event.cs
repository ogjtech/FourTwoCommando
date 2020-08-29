using System;

namespace Data.database.models
{
    public class Event
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Description { get; set; }
        
        public Mission Mission { get; set; }
    }
}