namespace SharedAbstraction
{
    public class OrderCreated
    {
        public Guid ID { get; set; }
        public IList<ProductDTO> Products { get; set; }
    }

    public class ProductDTO
    {
        public Guid productid { get; set; }
        public int quantity { get; set; }
    }
}