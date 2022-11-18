using Decorator_Design_Pattern.Component;

namespace Decorator_Design_Pattern.Decorator
{
    //Concrete Decorators
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
}
