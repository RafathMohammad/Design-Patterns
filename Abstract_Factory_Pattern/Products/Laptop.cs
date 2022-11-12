using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Products
{
    class DellLaptop : ILaptop
    {
        public string Handover()
        {
            return "It is a laptop of Dell company";
        }
    }
    class HPLaptop : ILaptop
    {
        public string Handover()
        {
            return "It is a laptop of HP company";
        }
    }
}
