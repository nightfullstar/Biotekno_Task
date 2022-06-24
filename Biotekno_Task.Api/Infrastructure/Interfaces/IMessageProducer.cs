namespace Biotekno_Task.Api.Infrastructure.Interfaces
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message, string queue);
    }
}
