using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Design_Pattern
{
    public interface IVisitor
    {
        void Visit(Patient patient);
    }
}
