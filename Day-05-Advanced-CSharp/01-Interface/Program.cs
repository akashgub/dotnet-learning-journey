interface IPayment
{
    void Pay();
}

class BkashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed using bKash");
    }
}
class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment completed using Card");
    }
}
class Program
{
    static void Main()
    {
        IPayment payment1 = new BkashPayment();
        payment1.Pay();

        IPayment payment2 = new CardPayment();
        payment2.Pay();

    }
}