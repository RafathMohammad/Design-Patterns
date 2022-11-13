using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Tiger:IAnimal
    {
        public string Type()
        {
            return "Tiger is a Wild Animal";
        }
        public string Action()
        {
            return "Tiger grunts";
        }
    }
}
