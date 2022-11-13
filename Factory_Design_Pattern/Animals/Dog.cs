using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Dog:IAnimal
    {
        public string Type()
        {
            return "Dog is a Domestic Animal";
        }
        public string Action()
        {
            return "Dog Barks";
        }
    }
}
