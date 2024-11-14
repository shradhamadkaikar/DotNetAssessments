using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.OverloadingAssessment
{
    public class MainProgram
    {
        //1. WAP to overload add method
        //static void Main(string[] args)
        //{
        //    OverloadAddMethod calc = new OverloadAddMethod();
        //    Console.WriteLine(calc.Add(10, 20));           
        //    Console.WriteLine(calc.Add(10, 20, 30));      
        //    Console.WriteLine(calc.Add(10, 20.5f));        
        //    Console.WriteLine(calc.Add(10, 25.75));        
        //}


        //2. WAP to overload constructor in Employee class
        //static void Main(string[] args)
        //{

        //    Employee emp3 = new Employee(103, "Bob", 50000);
        //    emp3.Display();
        //}


        //3. Create a class Payment having a static method payBill
        //If you pay the bill by cash you are not eligible for any discount, method payBill(double amt)
        //If you pay by a mode you get 15% discount on the bill, method  payBill(double amt, String mode)

        //static void Main(string[] args)
        //{
        //    Payment.payBill(5000);

        //    Payment.payBill(5000, "Credit Card");
        //}

    }
}
