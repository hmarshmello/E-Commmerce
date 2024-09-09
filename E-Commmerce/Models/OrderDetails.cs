namespace E_Commmerce.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public Orders Order { get; set; }
        public Product Product { get; set; }
    }
}
