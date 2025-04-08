using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoviKonverzija4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                Console.WriteLine("String i bool nikada nisu kompatibilni no s ovom metodom to možemo rješiti.");
                                 
            }
            
        }
    }
}
