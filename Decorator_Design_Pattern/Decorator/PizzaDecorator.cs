using Decorator_Design_Pattern.Component;

namespace Decorator_Design_Pattern.Decorator
{
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
}
