
namespace EcommerceDomain
{
    public partial class Product: IAggregateRoot
    {
        public static Product Create(string Name,decimal? Minimum,Guid ID) 
        {
            Product product = new Product
            {
                Name = Name,
                MinimumQuantity = Minimum,
                ExpiryDate = DateTime.Now,
                Id = ID
            };
            return product;
        }
    }
}
