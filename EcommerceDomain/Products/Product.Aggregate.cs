
namespace EcommerceDomain
{
    public partial class Product: IAggregateRoot
    {
        public static Product Create(string Name,decimal? Minimum,Guid ID,int quantity) 
        {
            Product product = new Product
            {
                Name = Name,
                MinimumQuantity = Minimum,
                ExpiryDate = DateTime.Now,
                Id = ID,
                CurrentQuantity = quantity
            };
            return product;
        }

        public static Product UpdateQuantity(Product product,int quantity)
        {
            product.CurrentQuantity = product.CurrentQuantity-quantity;
            return product;
        }
    }
}
