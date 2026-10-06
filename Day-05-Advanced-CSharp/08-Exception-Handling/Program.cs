class BankAccount
{
    public string AccountHolder { get; set; }

    public double Balance { get; private set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Deposit amount must be greater than zero.");
        }

        Balance += amount;

        Console.WriteLine($"{AccountHolder} deposited: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new Exception("Withdrawal amount must be greater than zero.");
        }

        if (amount > Balance)
        {
            throw new Exception("Insufficient balance.");
        }

        Balance -= amount;

        Console.WriteLine($"{AccountHolder} withdrew: {amount}");
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Akash", 50000);

        try
        {
            account.ShowBalance();

            account.Deposit(10000);

            account.Withdraw(15000);

            account.ShowBalance();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}