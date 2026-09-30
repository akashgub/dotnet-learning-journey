/*
sealed class BankAccount
{
    public void ShowAccountType()
    {
        Console.WriteLine("This is a bank account");
    }
}
class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.ShowAccountType();
    }
}
*/
sealed class Employee
{
    public void ShowInfo()
    {
        Console.WriteLine("Employee information");
    }
}
class Program 
{
    static void Main()
    {
        Employee employee = new Employee();
        
        employee.ShowInfo();
    }
}