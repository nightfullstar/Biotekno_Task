namespace Biotekno_Task.Api.Core.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
