namespace Biotekno_Task.Api.Model
{
    public class OrderRequest
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerGSM { get; set; }
        public List<ProductDetail> productDetails { get; set; }
        public virtual double TotalAmount { get; set; }

    }
}
