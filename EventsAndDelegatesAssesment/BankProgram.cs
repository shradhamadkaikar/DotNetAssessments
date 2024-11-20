using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.DelicatesAndEvent.Assesment
{
    public class BankProgram
    {
        public delegate void DisplayMessage();

        //static void InsufficientBalanceMsg()
        //{
        //    Console.WriteLine("Insufficient balance!");
        //}
        //static void ZeroBalanceMsg()
        //{
        //    Console.WriteLine("Your balance is zero.");
        //}
        //static void LowBalanceMsg()
        //{
        //    Console.WriteLine("Low balance!");
        //}


        //static void Main(string[] args)
        //{
        //    Bank bank = new Bank(3000);

        //    bank.InsufficientBalance += new DisplayMessage(InsufficientBalanceMsg);
        //    bank.LowBalance += new DisplayMessage(LowBalanceMsg);
        //    bank.ZeroBalance += new DisplayMessage(ZeroBalanceMsg);

        //    bank.Credit(1000);  // credit
           
        //    bank.Debit(2000);   // Debit

        //    bank.Debit(6000);   // debit more than available balance

        //    bank.Debit(2000);   // Debit remaining balance, balance will reach zero
        //}
    }
}
