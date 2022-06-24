namespace Biotekno_Task.Api.Model
{
    public class Product : BaseModel
    {
      
        public string Description { get; set; }
        public string Category { get; set; }
        public int Unit { get; set; }
        public double UnitPrice { get; set; }
    }
}
