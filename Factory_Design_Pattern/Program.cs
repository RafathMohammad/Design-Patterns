using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal wild = new AnimalFactory().CreateAnimal("Wild");
            IAnimal domestic = new AnimalFactory().CreateAnimal("Domestic");
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", wild.Type(), wild.Action(), domestic.Type(), domestic.Action());
            Console.ReadLine();
        }
    }
}
