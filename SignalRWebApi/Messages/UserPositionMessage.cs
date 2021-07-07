using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Messages
{
    public class UserPositionMessage
    {
        public string UserName { get;  }
        public decimal Longitude { get;  }
        public decimal Latitude { get; }
        public DateTime CreatedDateTime { get; }

        public UserPositionMessage(string username,decimal latitud,decimal longitude)
        {
            CreatedDateTime = DateTime.UtcNow;
            UserName = username;
            Latitude = latitud;
            Longitude = longitude;
        }
    }
}
