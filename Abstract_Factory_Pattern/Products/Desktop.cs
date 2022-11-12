using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Products
{
        class DellDesktop : IDesktop
        {
            public string Handover()
            {
               return "It is a Desktop of Dell company";
            }
        }
        class HPDesktop : IDesktop
        {
            public string Handover()
            { 
                return "It is a Desktop of HP company";
            }
        }
}
