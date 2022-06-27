namespace Biotekno_Task.Api.Core.Entity
{
    public class Product : BaseEntity
    {
       
        public string Description { get; set; }

        public string Category { get; set; }
        public int Unit { get; set; }

        public double UnitPrice { get; set; }
       
        public bool Status { get; set; }

    }
}
