using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Messages
{
    public class UserPositionMessage
    {
        public string UserName { get;  }
        public double Longitude { get;  }
        public double Latitude { get; }
        public DateTime CreatedDateTime { get; }

        public UserPositionMessage(string username,double latitud,double longitude)
        {
            CreatedDateTime = DateTime.UtcNow;
            UserName = username;
            Latitude = latitud;
            Longitude = longitude;
        }
    }
}
