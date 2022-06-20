namespace Capstone.WebApi.Models
{
    public class OrderModel
    {

        public string CourierName { get; set; }
        public string CustomerCourierRef { get; set; }
       // public DateTime DeliveryDate { get; set; }
        public string DeliveryMethod { get; set; }
        public string ExpressCarrier { get; set; }
        public int OrderId { get; set; }
        public string TrackingStatus { get; set; }
       // public DateTime UpdatedDateTime { get; set; }
        // public AddressModel DeliveryAddress { get; set; }
        //public AddressModel MarketDeliveryAddress { get; set; }
       // public IList<OrderLineItemModel> LineItems { get; set; }
        //public OrderPaymentDetailsModel PaymentDetails { get; set; }
        //  public ShopperModel Shopper { get; set; }
        // public DeliveryWindowModel DeliveryWindow { get; set; }
        // public IList<MarketOrderModel> MarketOrders { get; set; }
        public bool IsMarketOnly { get; set; }
        public bool IsMarketOrder { get; set; }
        public bool HasMarketOrderGiftingDetails { get; set; }
    }
}
