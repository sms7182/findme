using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi
{
    public class EventMessage
    {
        public Guid Id { get;  }
        public string Title { get;  }
        public DateTime CreatedDateTime { get;  }
        public EventMessage(Guid id,string title,DateTime createdDateTime)
        {
            Id = id;
            Title = title;
            CreatedDateTime = createdDateTime;
        }
    }
}
