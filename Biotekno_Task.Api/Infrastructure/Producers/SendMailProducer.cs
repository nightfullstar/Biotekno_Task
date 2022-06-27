using Biotekno_Task.Api.Infrastructure.Interfaces;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Biotekno_Task.Api.Infrastructure.Producers
{
    public class SendMailProducer : ISendMailProducer
    {
        public Serilog.ILogger _logger;
        public SendMailProducer(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void SendMail(string mail)
        {
            var factory = new ConnectionFactory { HostName = "localhost" };
            var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare("email-send", false, false, false);
            channel.QueueBind("email-send", "email-box", "email-add");
            var json = JsonConvert.SerializeObject(mail);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish("email-send", "email-box", null, body);
            _logger.Information("Mail sending process produced: " + json);
        }
    }
}
