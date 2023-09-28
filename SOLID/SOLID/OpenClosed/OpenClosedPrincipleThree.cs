using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Initialise account class
        Account account = new Account();
        account.Name = "John Doe";
        account.Address = "123 Street";
        account.Balance = 1000;

        IAccount obj = new SavingAccount();
        Console.WriteLine(obj.CalculateInterest(obj));
    }
}

// NON-COMPLIANT
// public class Account
// {
//     public string Name { get; set; }
//     public string Address { get; set; }
//     public double Balance { get; set; }
//     public double CalculateInterest (string accountType)
//     {
//         if(accountType == "Saving")
//             return Balance * 0.3;
//         else
//         {
//             return Balance * 0.5;
//         }
//     }
// }

public class OpenClosePrincipleComplaint { }

public class Account
{
    public string Name { get; set; }
    public string Address { get; set; }
    public double Balance { get; set; }
}

public interface IAccount
{
    double CalculateInterest(Account account);
}

public class SavingAccount : IAccount
{
    public double CalculateInterest(Account account)
    {
        return account.Balance * 0.3;
    }
}

public class CurrentAccount : IAccount
{
    public double CalculateInterest(Account account)
    {
        return account.Balance * 0.5;
    }
}

public class OtherAccount : IAccount
{
    public double CalculateInterest(Account account)
    {
        return account.Balance * 0.5;
    }
}
