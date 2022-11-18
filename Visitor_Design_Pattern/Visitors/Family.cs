using System;

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
