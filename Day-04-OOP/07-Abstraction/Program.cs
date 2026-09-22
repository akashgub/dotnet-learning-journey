abstract class Payment
{
    public abstract void Pay();

    public void ShowMessage(){
        Console.WriteLine("Payment processing...");
    }
}

class BkashPayment : Payment
{
    public override void Pay(){
        Console.WriteLine("Paid using Bkash.\n");
    }
}

class CardPayment : Payment
{
    public override void Pay(){
        Console.WriteLine("Paid using Card.");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Payment payment1 = new BkashPayment();

        payment1.ShowMessage();
        payment1.Pay();

        Payment payment2 = new CardPayment();

        payment2.ShowMessage();
        payment2.Pay();
    }
}
