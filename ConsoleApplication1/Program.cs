using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ch = new Character();
            ch.Order(2);
            ch.Order(3);
            ch.Order(1);
            ch.Order(4);
            Console.ReadKey();

        }
    }
}
