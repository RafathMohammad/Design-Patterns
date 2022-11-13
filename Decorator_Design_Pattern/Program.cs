using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            IPizza tomatoDecorator = new TomatoDecorator(cheesedecorator);
            Console.WriteLine(tomatoDecorator.GetPizzaType());

            IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
            Console.WriteLine(onionDecorator.GetPizzaType());

            IPizza tomatoDecorator1 = new TomatoDecorator(pizza);
            IPizza onionDecorator1 = new OnionDecorator(tomatoDecorator1);
            Console.WriteLine(onionDecorator1.GetPizzaType());

            Console.ReadLine();
        }
        //base interface
        interface IPizza
        {
            string GetPizzaType();
        }
        //concrete implementation
        class Pizza : IPizza
        {
            public string GetPizzaType()
            {
                return "This is a Pizza";
            }
        }
        //base decorator
        class PizzaDecorator : IPizza
        {
            private IPizza _pizza;
            public PizzaDecorator(IPizza pizza)
            {
                _pizza = pizza;
            }
            public virtual string GetPizzaType()
            {
                return _pizza.GetPizzaType();
            }

        }
        //Concrete Decorators
        class CheeseDecorator : PizzaDecorator
        {
            public CheeseDecorator(IPizza pizza) :base(pizza){ }
            public override string GetPizzaType()
            {
                string type = base.GetPizzaType();
                type += " with extra Cheese";
                return type;
            }
        }
        class TomatoDecorator : PizzaDecorator
        {
            public TomatoDecorator(IPizza pizza) : base(pizza) { }
            public override string GetPizzaType()
            {
                string type = base.GetPizzaType();
                type += " with extra Tomatoes";
                return type;
            }
        }
        class OnionDecorator : PizzaDecorator
        {
            public OnionDecorator(IPizza pizza) : base(pizza) { }
            public override string GetPizzaType()
            {
                string type = base.GetPizzaType();
                type += " with extra Onions";
                return type;
            }
        }
    }
}
