using System;

namespace TodoWebApi.Core.Models
{
    public class Todo : Entity<int>
    {
        public DateTime CreatedOn { get; set; }

        public DateTime CompletedOn { get; set; }
        
        public string Title { get; set; }
        
        public bool Completed { get; set; }

    }
}
