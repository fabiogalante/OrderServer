using System;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using Shared.Model;

namespace OrderConsumer.Consumers
{
    public class TicketConsumer : IConsumer<Ticket>
    {
        private readonly ILogger<TicketConsumer> logger;

        public TicketConsumer(ILogger<TicketConsumer> logger)
        {
            this.logger = logger;
        }

        public async Task Consume(ConsumeContext<Ticket> context)
        {
            await Console.Out.WriteLineAsync(context.Message.UserName);
            logger.LogInformation($"Nova mensagem recebida :" +
                                  $" {context.Message.UserName} {context.Message.Location}");
        }
    }
}
