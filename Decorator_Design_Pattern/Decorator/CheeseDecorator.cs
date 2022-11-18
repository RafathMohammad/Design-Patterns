using Decorator_Design_Pattern.Component;

namespace Decorator_Design_Pattern.Decorator
{
    //Concrete Decorators
    class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += " with extra Cheese";
            return type;
        }
    }
}
