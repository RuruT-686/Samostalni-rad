using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number = 9;
            int count = 10;
            float totalPrice = 23.44f;        //Var se koristi kao skraćenica,program sam prepozna.

            char character = 'A';             //Karaktere zatvaramo polunavodnicima,string navodnicima.
            string frstName = "Polly Crack";
            bool isworking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(frstName);
            Console.WriteLine(isworking);
        }
    }
}
