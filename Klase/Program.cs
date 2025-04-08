using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FirstProject.People;

namespace FirstProject
{
    class program

    {
       
        static void Main(string[] args)
        {
            Person person = new Person();

            person.name = "Andy";
            person.age = 34;
            person.haspets = true;

            person.Greetings();


        }
    }
}
