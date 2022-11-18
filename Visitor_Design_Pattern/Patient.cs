using System;

namespace Visitor_Design_Pattern
{
    public class Patient
    {
        public string _name = "";
        public Patient(String Name)
        {
            _name = Name;
        }

        // The Component interface declares an `accept` method that should take the
        // base visitor interface as an argument.

        public void Accept(IVisitor visitor)  
        {
            visitor.Visit(this); //we're calling `Visit', which matches the
                                 // current class name. This way we let the visitor know the class of the
                                 // component it works with.
        }
    }
}
