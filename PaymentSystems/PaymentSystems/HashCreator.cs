using System;
using System.Security.Cryptography;
using System.Text;

namespace PaymentSystems
{
    public class HashCreator : IHashCreator
    {
        private HashAlgorithm _hashAlgorithm;

        public HashCreator(HashAlgorithm hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;
        }

        public string GetHash(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentOutOfRangeException(nameof(input));

            byte[] hashBytes = _hashAlgorithm.ComputeHash(Encoding.Default.GetBytes(input));

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
            {
                result.Append(hashBytes[i].ToString("x2"));
            }

            return result.ToString();
        }
    }
}
