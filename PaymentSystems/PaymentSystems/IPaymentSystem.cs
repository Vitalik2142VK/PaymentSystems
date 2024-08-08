namespace PaymentSystems
{
    public interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}
