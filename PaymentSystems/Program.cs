using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PaymentSystems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orederId = 1;
            int orederAmount = 12000;
            Order order = new Order(orederId, orederAmount);

            IHashCreator creatorMD5 = new HashCreator(MD5.Create());
            IHashCreator creatorSHA1 = new HashCreator(SHA1.Create());

            List<IPaymentSystem> paymentSystems = new List<IPaymentSystem>()
            {
                new FirstPaymentSystem(creatorMD5),
                new SecondPaymentSystem(creatorMD5),
                new ThirdPaymentSystem(creatorSHA1)
            };

            foreach (var paymentSystem in paymentSystems)
            {
                Console.WriteLine(paymentSystem.GetPayingLink(order));
            }

            Console.ReadKey();
        }
    }
}
