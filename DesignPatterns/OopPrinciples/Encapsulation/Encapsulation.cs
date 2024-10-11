namespace DesignPatterns.OopPrinciples.Encapsulation;

public static class Encapsulation
{
    public static void Run()
    {
        // Encapsulation is the process of hiding the internal state of an object and requiring all interactions to be performed through an object's methods.

        // This is a bad practice because the Balance field is public and can be modified from anywhere in the code.
        // // This is a violation of the encapsulation principle.
        // // The Balance field should be private and only accessible through the Deposit and Withdraw methods.
        var badBankAccount = new BadBankAccount
        {
            Balance = -1000
        };
        Console.WriteLine(badBankAccount.Balance);

        //-----------------------------------------------------------------------------------------------

        // This is a good practice because the Balance field is private and can only be modified through the Deposit and Withdraw methods.
        // // This is an example of encapsulation.
        var bankAccount = new BankAccount(100);
        Console.WriteLine(bankAccount.GetBalance());

        bankAccount.Deposit(50);
        Console.WriteLine(bankAccount.GetBalance());

        bankAccount.Withdraw(100);
        Console.WriteLine(bankAccount.GetBalance());
    }
}