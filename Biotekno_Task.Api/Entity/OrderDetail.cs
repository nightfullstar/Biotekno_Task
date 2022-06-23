using System.ComponentModel.DataAnnotations.Schema;

namespace Biotekno_Task.Api.Entity
{
    public class OrderDetail : BaseEntity
    {
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
        public int OrderId { get; set; }


        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        public double UnitPrice { get; set; }


    }
}
