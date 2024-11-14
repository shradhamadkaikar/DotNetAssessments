using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.ConstructorAssesment
{
    public class Bank
    {
        private double balance;
        public Bank(double Bal)
        {
            balance = Bal;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Amount Deposited: {amount}\n" +
                                  $"Current Balance: {balance}");
                Console.WriteLine("-------------------");
            }
            else
            {
                Console.WriteLine("Deposit amount should be positive.");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}\n" +
                                  $"Current Balance: {balance}");
                Console.WriteLine("-----------------------");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Current Balance: {balance}");
        }
    }
}
