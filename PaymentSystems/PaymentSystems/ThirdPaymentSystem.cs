namespace PaymentSystems
{
    public class ThirdPaymentSystem : PaymentSystem
    {
        private string _secretKey = "someSecretKey";

        public ThirdPaymentSystem(IHashCreator hashCreator) : base(hashCreator) { }

        public override string GetPayingLink(Order order)
        {
            ThrowEcxeptionIfArgumentNull(order);

            string hash = HashCreator.GetHash((order.Id + order.Amount + _secretKey).ToString());

            return $"system3.com/pay?amount={order.Amount}&curency=RUB&hash={{{hash}}}";
        }
    }
}
