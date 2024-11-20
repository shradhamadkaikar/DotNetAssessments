using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.AbstractClasses
{
    public class BankMain
    {
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount(5000);
            s1.Deposit(1000);
            s1.Withdraw(1000);


            CurrentBalance c1 = new CurrentBalance(15000);
            c1.Deposit(25000);

        }
    }
}
