using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.AbstractClasses
{
    abstract public class BankAccount
    {
        public abstract void Deposit(double amt);

        public abstract void Withdraw(double amt);

    }

    public class SavingsAccount : BankAccount
    {
        private double balance;

        public SavingsAccount(double balance)
        {
            this.balance = balance;
        }

        public override void Deposit(double amt)
        {
            balance = balance + amt;
            Console.WriteLine("Available Balance:" + balance);
        }

        public override void Withdraw(double amt)
        {
            if (amt <= balance)
            {
                balance = balance - amt;
                Console.WriteLine("balance withrawn");
                Console.WriteLine("Available Balance:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance ");
            }

        }

        public override string ToString()
        {
            return $"Total balance is: {balance}";
        }

    }

    public class CurrentBalance : BankAccount
    {
        private double maxDeposite;

        public CurrentBalance(double maxDeposite)
        {
            this.maxDeposite = maxDeposite;
        }

        public override void Deposit(double amt)
        {
            if (amt > maxDeposite)
            {
                maxDeposite = maxDeposite + amt;
                Console.WriteLine($"{maxDeposite} is deposited");
            }
            else
            {
                Console.WriteLine("Deposit amount is exeeded!! maximum amount is 20000");

            }
        }

        public override void Withdraw(double amt)
        {
            if (amt <= maxDeposite)
            {
                maxDeposite = maxDeposite - amt;
                Console.WriteLine("balance withrawn");
                Console.WriteLine("Available Balance:" + maxDeposite);
            }
            else
            {
                Console.WriteLine("Insufficient balance ");
            }

        }

        public override string ToString()
        {
            return $"Total balance is: {maxDeposite}";
        }
    }

}