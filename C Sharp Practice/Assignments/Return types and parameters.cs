using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Car
    {
        public void MotorOn()
        {
            Console.WriteLine("The motor is on");
        }

        public void MotorOff()
        {
            Console.WriteLine("The motor is off");
        }

        public void FillGas(double liters, bool isDiesel)
        {
            Console.Write("Filled tank with: " + liters + " liters ");

            if (isDiesel = true)
            {
                Console.Write("diesel");
            }
            else
            {
                Console.Write("bezin");
            }
        }

        public void RemainingGas(double litersLeft)
        {

        }
    }
}
