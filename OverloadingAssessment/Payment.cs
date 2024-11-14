using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.OverloadingAssessment
{
    public class Payment
    {
        public static void payBill(double amt)
        {
            Console.WriteLine($"Total Bill: {amt}"); //(No Discount)
        }

        public static void payBill(double amt, string mode)
        {
            double discountedAmt = amt * 0.85; //  15% discount
            Console.WriteLine($"Total Bill after 15% Discount for payment by {mode}: {discountedAmt}");
        }
    }
}
