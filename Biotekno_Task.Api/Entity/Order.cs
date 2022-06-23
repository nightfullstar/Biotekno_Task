namespace Biotekno_Task.Api.Entity
{
    public class Order : BaseEntity
    {
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerGsm { get; set; }

        public double TotalAmount { get; set; }
    }
}
