namespace Biotekno_Task.Api.Infrastructure.Producers
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message, string queue);
    }
}
