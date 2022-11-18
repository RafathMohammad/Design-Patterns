namespace Decorator_Design_Pattern.Component
{
    //concrete implementation
    class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a Pizza";
        }
    }
}
