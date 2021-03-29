using System;

namespace TodoWebApi.Core.Models
{
    public class Todo : Entity<int>
    {
        public DateTime CreatedOn { get; set; }

        public bool Complete { get; set; }

        public DateTime CompletedOn { get; set; }
        
        public string Title { get; set; }

    }
}
