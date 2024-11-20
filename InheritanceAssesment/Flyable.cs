using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.AbstractClasses
{
    public interface Flyable
    {
        void FlyObj();
    }

    public class Spacecraft : Flyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft is flying out of the space!");
        }
    }

    public class Airplane : Flyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Airplane is flying at high in the sky!");
        }
    }

    public class Chopper : Flyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Chopper is mostly flying close to the ground!");
        }
    }
}
