namespace PaymentSystems
{
    public class FirstPaymentSystem : PaymentSystem
    {
        public FirstPaymentSystem(IHashCreator hashCreator) : base(hashCreator) {}

        public override string GetPayingLink(Order order)
        {
            ThrowEcxeptionIfArgumentNull(order);

            string hash = HashCreator.GetHash(order.Id.ToString());

            return $"pay.system1.ru/order?amount={order.Amount}RUB&hash={{{hash}}}";
        }
    }
}
