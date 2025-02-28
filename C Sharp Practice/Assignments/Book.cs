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

        //InstanceVariables1
        public int price { get; set; }
        public string title { get; set; }

        public void CanAffordPart2(int money)
        {
            if (money > price)
            {
                Console.WriteLine(title + " costs " + price + "kr.\nYou have {0} and can therefore afford it!", money);
            }
            else
            {
                Console.WriteLine(title + " costs " + price + "kr.\nYou have {0} and can therefore NOT afford it!", money);
            }
        }

        //Constructor1
        public string author;

        public Book()
        {
            author = "James Dashner";
        }
    }
}
