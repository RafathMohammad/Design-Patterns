using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    public class Patient
    {
        public string _name = "";
        public Patient(String Name)
        {
            _name = Name;
        }
        public void Attend(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
