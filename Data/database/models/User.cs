using System;

namespace Data.database.models
{
    public class User
    {
        public Guid Id { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public Rank Rank { get; set; }
        
        public Role[] Roles { get; set; }
    }
}