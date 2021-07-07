using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRWebApi.Helpers;
using SignalRWebApi.Hubs;
using SignalRWebApi.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IHubContext<MessageBrokerHub> _messageBrokerHubContext;
        public UserInfoController(IHubContext<MessageBrokerHub> messageBrokerHubContext)
        {
            _messageBrokerHubContext = messageBrokerHubContext;
        }
      
        [HttpPost]
        public async Task<IActionResult> UserPosition(UserPosition userPosition)
        {
            var message=new UserPositionMessage(userPosition.UserName,userPosition.Latitude,userPosition.Longitude);
          await  _messageBrokerHubContext.Clients.All.SendAsync("onMessageReceived", message, cancellationToken: default);
            return Ok();
        }

    }
}
