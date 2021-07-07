using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using SignalRWebApi.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRWebApi.WorkerServices
{
    public sealed class MessageBrokerPubSubWorker:BackgroundService
    {
        private readonly IHubContext<MessageBrokerHub> _messageBrokerHubContext;
        public MessageBrokerPubSubWorker(IHubContext<MessageBrokerHub> messageBrokerHubContext)
        {
            _messageBrokerHubContext = messageBrokerHubContext;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000);
                var eventMessage = new EventMessage(Guid.NewGuid(), Guid.NewGuid().ToString(), DateTime.UtcNow);
               // await _messageBrokerHubContext.Clients.All.SendAsync("onMessageReceived",eventMessage, stoppingToken);
            }
        }
    }
}
