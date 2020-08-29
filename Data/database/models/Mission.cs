using System;

namespace Data.database.models
{
    public class Mission
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public Event[] Events { get; set; }
    }
}