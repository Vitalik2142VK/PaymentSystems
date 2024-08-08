using System;

namespace PaymentSystems
{
    public abstract class PaymentSystem : IPaymentSystem
    {
        private IHashCreator _hashCreator;

        public PaymentSystem(IHashCreator hashCreator)
        {
            _hashCreator = hashCreator ?? throw new ArgumentNullException(nameof(hashCreator));
        }

        protected IHashCreator HashCreator => _hashCreator;

        protected void ThrowEcxeptionIfArgumentNull(Order order)
        {
            if (order == null) 
                throw new ArgumentNullException(nameof(order));
        }

        public abstract string GetPayingLink(Order order);
    }
}
