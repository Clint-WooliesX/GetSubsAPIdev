namespace Capstone.WebApi.Models
{
    public class OrderLineItemModel
    {

        public string StockCode { get; set; }
        public string Name { get; set; }
        public int LineNumber { get; set; }
        public string PricingUnit { get; set; }
        public decimal OrderedQuantity { get; set; }
        public decimal SuppliedQuantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Total { get; set; }
        //  public OrderAdjustmentModel Adjustment { get; set; }
        //  public ProductModel Product { get; set; }
    }
}
