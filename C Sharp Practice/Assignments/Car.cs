using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Car
    {
        //ReturnTypesAndParameters1
        public void MotorOn()
        {
            Console.WriteLine("The motor is on");
        }

        public void MotorOff()
        {
            Console.WriteLine("The motor is off");
        }

        //ReturnTypesAndParameters2&3
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

        //ReturnTypesAndParameters4
        public void RemainingGas(double litersLeft)
        {
            Console.WriteLine("You have {0} liters left in your tank", litersLeft);
        }
    }
}
