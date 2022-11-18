using System;

namespace Visitor_Design_Pattern
{
    public class Physician : IVisitor
    {
        public void Visit(Patient patient)
        {
            Console.WriteLine("checkup done by Physician and patient is fine");
        }
    }
}
