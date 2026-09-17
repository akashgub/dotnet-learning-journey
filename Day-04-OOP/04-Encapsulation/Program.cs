class BankAccount
{
    private int balance;

    public BankAccount(int initialBalance)
    {
        if (initialBalance >= 0)
        {
            balance = initialBalance;
        }
        else
        {
            balance = 0;
        }
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }

    public int GetBalance()
    {
        return balance;
    }
}

class Test
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);

        account.Deposit(500);
        account.Withdraw(200);

        Console.WriteLine($"Final Balance: {account.GetBalance()}");
    }
}