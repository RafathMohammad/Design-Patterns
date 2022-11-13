using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    class Dentist : IVisitor
    {
        public void Visit(Patient patient)
        {
            Console.WriteLine("checkup done by Dentist and patient teeth is strong");
        }
    }
}
