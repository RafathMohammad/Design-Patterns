using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    class Nurse : IVisitor
    {
        public void Visit(Patient patient)
        {
            Console.WriteLine("Nurse has recorded BP and pulse");
        }
    }
}
