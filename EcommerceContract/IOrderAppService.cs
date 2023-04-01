namespace EcommerceContract
{
    public interface IOrderAppService
    {
        public bool OrderDonePurshase(OrderDTO order);
        public bool OrderCanceled(Guid id);
    }
}