using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverzijaTipova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //int i = 1;         Pošto je vrijednost dovoljno mala da se može pohraniti i 1 byte nema gubitka
           //byte b = (byte) i;  Zato smo dodali cast (byte) prije i. Ako an primjer dodamo 1000 umjesto 1 
          //ConsoleWriteline(b); program će i dalje raditi ali ćemo izgubiti na byte-vima(bit će manji broj.




        }
    }
}
