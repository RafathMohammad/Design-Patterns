using Decorator_Design_Pattern.Component;

namespace Decorator_Design_Pattern.Decorator
{
    //Concrete Decorators
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
