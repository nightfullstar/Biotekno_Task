using RabbitMQ.Client;
using RabbitMQ.Client.Events;   

namespace Biotekno_Task.Api.Infrastructure.Workers
{
    public class EmailWorker : BackgroundService
    {
        private Serilog.ILogger _logger;
        public EmailWorker(Serilog.ILogger logger) {
        _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.Information("Email worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000,stoppingToken);
            var factory = new ConnectionFactory { HostName = "localhost" };
            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, e) =>
            {
                var body = e.Body;
                var json = System.Text.Encoding.UTF8.GetString(body.ToArray());
            };
        }
    }
}
