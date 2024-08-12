using System;

namespace PaymentSystems
{
    public abstract class PaymentSystem : IPaymentSystem
    {
        protected PaymentSystem(IHashCreator hashCreator)
        {
            HashCreator = hashCreator ?? throw new ArgumentNullException(nameof(hashCreator));
        }

        protected IHashCreator HashCreator { get; }

        public abstract string GetPayingLink(Order order);

        protected void ThrowEcxeptionIfArgumentNull(Order order)
        {
            if (order == null) 
                throw new ArgumentNullException(nameof(order));
        }
    }
}
