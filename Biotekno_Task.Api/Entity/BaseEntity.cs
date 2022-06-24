using Biotekno_Task.Api.Infrastructure.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biotekno_Task.Api.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }


    }
}
