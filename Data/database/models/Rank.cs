using System;

namespace Data.database.models
{
    public class Rank
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Abbreviation { get; set; }
    }
}