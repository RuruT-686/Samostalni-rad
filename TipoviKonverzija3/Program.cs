using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoviKonverzija3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "5234";
                byte b = Convert.ToByte(number);  //How to handle exception. 
                Console.WriteLine(b);
            }
            catch (Exception)
            {
               Console.WriteLine("Broj nije mogao biti pretvoren u byte >.<"); 
                
            }           

        }
    }
}
