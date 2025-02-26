using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Book
    {
        //MethodsAndInstances1
        public void PrintInfo()
        {
            Console.WriteLine("I'm a book");
        }

        //MethodsAndInstances2
        public void CanAfford(int price, int wallet)
        {
            if (price < wallet)
            {
                Console.WriteLine("I can afford it");
            }
            else
            {
                Console.WriteLine("I can't afford it");
            }
        }
    }
}
