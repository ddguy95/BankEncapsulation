using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        { 
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much money do you want to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);
            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: ${userBalance}");

        }
    }
}
