using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
