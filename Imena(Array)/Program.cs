using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imena_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name01 = "Daniel";
            string name02 = "Kiwi";
            string name03 = "Dalila";
            string name04 = "Leticija";

            string[] names = new string[4] { "Daniel", "Kiwi", "Dalila", "Leticija" };
            //Koristimo ako već znamo što ide u array.U jendoj liniji sve dodajemo.:) 

            names[0] = "Daniel";
            names[1] = "Kiwi";
            names[2] = "Dalila";
            names[3] = "Leticija";
            //AKo ne znamo što ćemo staviti u array,obavezno se počine od nule.

            Console.WriteLine(names[3]);
            
                
        }
    }
}
