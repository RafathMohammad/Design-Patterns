using Decorator_Design_Pattern.Component;
using Decorator_Design_Pattern.Decorator;
using System;

namespace Decorator_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            Console.WriteLine(pizza.GetPizzaType());

            IPizza cheesedecorator = new CheeseDecorator(pizza);
            Console.WriteLine(cheesedecorator.GetPizzaType());

            IPizza tomatodecorator = new TomatoDecorator(cheesedecorator);
            Console.WriteLine(tomatodecorator.GetPizzaType());

            IPizza oniondecorator = new OnionDecorator(tomatodecorator);
            Console.WriteLine(oniondecorator.GetPizzaType());

            IPizza tomatodecorator1 = new TomatoDecorator(pizza);
            IPizza oniondecorator1 = new OnionDecorator(tomatodecorator1);
            Console.WriteLine(oniondecorator1.GetPizzaType());

            Console.ReadLine();
        }
    }
}
