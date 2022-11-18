using System;

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
