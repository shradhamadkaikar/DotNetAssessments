using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.AbstractClasses
{
    public class flyableMain
    {
        static void Main(string[] args)
        {
            Flyable spacecraft = new Spacecraft();
            Flyable airplane = new Airplane();
            Flyable chopper = new Chopper();

          
            spacecraft.FlyObj();
            airplane.FlyObj();
            chopper.FlyObj();
        }
    }
}
