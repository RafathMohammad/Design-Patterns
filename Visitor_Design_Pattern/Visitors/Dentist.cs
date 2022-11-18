using System;

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
