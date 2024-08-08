namespace PaymentSystems
{
    public interface IHashCreator
    {
        string GetHash(string input);
    }
}
