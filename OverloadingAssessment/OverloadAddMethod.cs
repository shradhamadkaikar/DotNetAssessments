using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.OverloadingAssessment
{
    public class OverloadAddMethod
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(int a, float b)
        {
            return a + b;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }
    }


}
