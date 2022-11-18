using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class AnimalFactory : IFactory
    {
        public IAnimal CreateAnimal(string animalType)
        {
            switch (animalType)
            {
                case "Tiger":
                    return new Tiger();
                case "Dog":
                    return new Dog();
                default:
                    return null;
            }
        }
    }
}
