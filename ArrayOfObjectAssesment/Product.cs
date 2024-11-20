using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.ArraysOfObject
{
    public class Product
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public double ProdPrice { get; set; }

        public override string ToString()
        {
            return $"Id ={ProdId} , Name= {ProdName} , Salary={ProdPrice}";
        }

    }
}
