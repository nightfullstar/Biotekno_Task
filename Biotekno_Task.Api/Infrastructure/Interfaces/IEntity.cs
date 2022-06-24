namespace Biotekno_Task.Api.Infrastructure.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
