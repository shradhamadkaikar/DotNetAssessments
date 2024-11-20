using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstDemo.DelicatesAndEvent.Assesment.BankProgram;
/*
Create a Bank a class, with Debit & Credit method
You can assign a default balance using constructor
Credit method will accept the amount that needs to be added in balance
Debit method will accept the amount that needs to be deducted from the balance.
If amount is greater than balance raise an event → insufficient balance
If balance is low (< 3000) raise an event low balance
If balance is zero then raise an event zero balance.
 */

namespace FirstDemo.DelicatesAndEvent.Assesment
{
    public class Bank
    {
        public event DisplayMessage InsufficientBalance;
        public event DisplayMessage LowBalance;
        public event DisplayMessage ZeroBalance;

        private double balance;

        public Bank(double dBalance)  //1.assign a default balance using constructor
        {
            balance = dBalance;
            Console.WriteLine("Available balance is: " + balance);
        }
        public void Credit(double amount)  //2.Credit method will accept the amount that needs to be added in balance
        {
            balance += amount;
            Console.WriteLine($"Amount Credited: {amount}");
            Console.WriteLine($"Current balance: {balance}");
            Console.WriteLine("---------------------------");
        }

        public void Debit(double amount)    //3.Debit method will accept the amount that needs to be deducted from the balance.

        {
            if (amount > balance)
            {
                InsufficientBalance();   // 4. If amount is greater than balance, raise an event → insufficient balance
                Console.WriteLine("------------------------------");

            }
            else
            {
                balance = balance - amount;
                Console.WriteLine($"Amount debited: {amount}");
                Console.WriteLine($"Current balance: {balance}");
                Console.WriteLine("------------------------------");

                // Check if balance becomes zero after debiting
                if (balance == 0)
                {
                    ZeroBalance();
                }

                // Check if balance is low (< 3000)
                if (balance < 3000)
                {
                    LowBalance();   // If balance is low (< 3000) raise an event for low balance
                }
            }
        }
    }
}

//{
//    balance = balance - amount;
//    Console.WriteLine($"Amount debited: {amount}");
//    Console.WriteLine($"Current balance: {balance}");
//    Console.WriteLine("------------------------------");

//    if (balance == 0)
//    {
//        ZeroBalance();
//    }
//    if (balance < 3000)
//    {
//        LowBalance();   // If balance is low (< 3000) raise an event low balance
//    }