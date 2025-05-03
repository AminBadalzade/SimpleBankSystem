using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem
{
    public class SavingAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingAccount(string owner, decimal interestRate) : base(owner +
             $" ({interestRate}%)")
        {
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;

            if (amount > 20000)
                return "You reached limit";
            decimal InterestAmount = (amount * InterestRate) / 100;
            Balance += amount + InterestAmount;
            return "Deposit completet succesfully";

        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You cannot withdraw $" + amount; 
            }
            if (amount > Balance)
            {
                return "You don't have enough money";
            }
            decimal InterestAmount = (amount * InterestRate) / 100;

            Balance -= amount + InterestAmount;
            return "Withdraw completet succesfully";

        }
    }
}
