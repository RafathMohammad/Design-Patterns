using System;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the animal");
            IAnimal animal = new AnimalFactory().CreateAnimal(Console.ReadLine());
            Console.WriteLine("{0}\n{1}\n", animal.Type(), animal.Action());
            Console.ReadLine();
        }
    }
}
