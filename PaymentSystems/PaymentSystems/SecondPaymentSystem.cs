namespace PaymentSystems
{
    public class SecondPaymentSystem : PaymentSystem
    {
        public SecondPaymentSystem(IHashCreator hashCreator) : base(hashCreator) { }

        public override string GetPayingLink(Order order)
        {
            ThrowEcxeptionIfArgumentNull(order);

            string hash = HashCreator.GetHash((order.Id + order.Amount).ToString());

            return $"order.system2.ru/pay?hash={{{hash}}}";
        }
    }
}
