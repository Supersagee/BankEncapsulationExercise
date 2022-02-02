using System;

namespace BankEncapsulationExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount();

            Console.WriteLine("How much money would you like to deposit?");
            double userDeposit = double.Parse(Console.ReadLine());

            account.Deposit(userDeposit);

            Console.WriteLine("Would you like to see the balance of your account? If you would, type YES");
            var userResponse = Console.ReadLine();

            if (userResponse == "YES")
            {
                Console.WriteLine($"Your account balance is {account.GetBalance()}. Have a wonderful day!");
            }
            else
            {
                Console.WriteLine($"Have a wonderful day!");
            }


        }
    }
}
