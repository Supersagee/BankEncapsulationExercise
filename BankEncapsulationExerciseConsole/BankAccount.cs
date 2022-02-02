using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExerciseConsole
{
    public class BankAccount
    {
        private double balance;
        
        public BankAccount()
        {

        }

        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public double GetBalance()
        {
            
            return balance;
        }
    }

}
