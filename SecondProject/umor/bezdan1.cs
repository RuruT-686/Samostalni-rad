using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class Osoba
    {
        public string ime;
        public int godine;
        public bool višeoddvijenekretnine;

        public void Dan()
        {
            Console.WriteLine("Dan moje ime je " + ime + " imam " + godine + " godina :).");
        }
    
    
    }

}
