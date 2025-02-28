using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Furniture
    {
        public int price { get; set; }
    }

    public class Chair : Furniture
    {
        public string chairBrand { get; set; }
        public string chairModel { get; set; }
    }

    public class Computer : Furniture
    {
        public string computerBrand { get; set; }
        public string computerModel { get; set; }

        public void ComputerInfo()
        {
            Console.WriteLine();
        }
    }
}
