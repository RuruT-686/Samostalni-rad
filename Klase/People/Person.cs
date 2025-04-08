using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.People 
{
    public class Person

    {
        public string name;
        public int age;
        public bool haspets;

        public void Greetings()
        {
            Console.WriteLine("Hi my name is " + name + " i am " + age + " years old :).");
        }
    }
}
