using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KlasaSamostalno
{
    public class Osoba
    {
        public string Ime;
        public int Godine;
        public bool StalniPosao;

        public void DobarDan()
        {
            Console.WriteLine("Dobar dan moje ime je " + Ime + " imam " + Godine + " godine :3.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.Ime = "Irma";
            osoba.Godine = 23;
            osoba.StalniPosao = true;

            osoba.DobarDan();

        }
    }
}
