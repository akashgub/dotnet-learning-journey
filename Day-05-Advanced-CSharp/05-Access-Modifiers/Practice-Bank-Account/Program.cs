class BankAccount
{
    // public
    public string AccountHolder;

    // private
    private double Balance;

    // protected
    protected string AccountNumber;

    // internal
    internal string BankName;


    public BankAccount(
        string accountHolder,
        double balance,
        string accountNumber,
        string bankName)
    {
        AccountHolder = accountHolder;
        Balance = balance;
        AccountNumber = accountNumber;
        BankName = bankName;
    }


    // public method
    public void ShowAccountInfo()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Bank Name: {BankName}");
    }


    // private member ব্যবহার করার জন্য public method
    public void Deposit(double amount)
    {
        Balance += amount;

        Console.WriteLine(
            $"{AccountHolder} deposited {amount}."
        );
    }


    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;

            Console.WriteLine(
                $"{AccountHolder} withdrew {amount}."
            );
        }
        else
        {
            Console.WriteLine(
                $"{AccountHolder} has insufficient balance."
            );
        }
    }
}


// Child class
class SavingsAccount : BankAccount
{
    public SavingsAccount(
        string accountHolder,
        double balance,
        string accountNumber,
        string bankName)
        : base(accountHolder, balance, accountNumber, bankName)
    {
    }


    // protected member access
    public void ShowAccountNumber()
    {
        Console.WriteLine(
            $"Account Number: {AccountNumber}"
        );
    }
}


class Program
{
    static void Main()
    {
        // Account 1
        SavingsAccount account1 = new SavingsAccount(
            "Akash",
            50000,
            "ACC-1001",
            "ABC Bank"
        );


        // Account 2
        SavingsAccount account2 = new SavingsAccount(
            "Rahim",
            75000,
            "ACC-1002",
            "ABC Bank"
        );


        // Account 3
        SavingsAccount account3 = new SavingsAccount(
            "Karim",
            100000,
            "ACC-1003",
            "ABC Bank"
        );


        // =========================
        // Account 1
        // =========================

        Console.WriteLine("===== Account 1 =====");

        // public
        Console.WriteLine(
            $"Account Holder: {account1.AccountHolder}"
        );

        // internal
        Console.WriteLine(
            $"Bank Name: {account1.BankName}"
        );

        // private member ব্যবহার হচ্ছে method-এর মাধ্যমে
        account1.Deposit(5000);

        account1.Withdraw(3000);

        // protected
        account1.ShowAccountNumber();

        account1.ShowAccountInfo();


        Console.WriteLine();


        // =========================
        // Account 2
        // =========================

        Console.WriteLine("===== Account 2 =====");

        // public
        Console.WriteLine(
            $"Account Holder: {account2.AccountHolder}"
        );

        // internal
        Console.WriteLine(
            $"Bank Name: {account2.BankName}"
        );

        // private member ব্যবহার হচ্ছে method-এর মাধ্যমে
        account2.Deposit(10000);

        account2.Withdraw(5000);

        // protected
        account2.ShowAccountNumber();

        account2.ShowAccountInfo();


        Console.WriteLine();


        // =========================
        // Account 3
        // =========================

        Console.WriteLine("===== Account 3 =====");

        // public
        Console.WriteLine(
            $"Account Holder: {account3.AccountHolder}"
        );

        // internal
        Console.WriteLine(
            $"Bank Name: {account3.BankName}"
        );

        // private member ব্যবহার হচ্ছে method-এর মাধ্যমে
        account3.Deposit(20000);

        account3.Withdraw(10000);

        // protected
        account3.ShowAccountNumber();

        account3.ShowAccountInfo();
    }
}