using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    class Family : IVisitor
    {
        public void Visit(Patient patient)
        {
            Console.WriteLine("Patient's family talked with patient and stayed with him for some time");
        }
    }
}
