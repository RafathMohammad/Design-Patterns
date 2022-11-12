using AbstractFactoryDesignpattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Products
{
    class DellHeadset : IHeadset
    {
        public string Handover()
        {
            return "It is a Headset of Dell company";
        }
    }
    class HPHeadset : IHeadset
    {
        public string Handover()
        {
            return "It is a Headset of HP company";
        }
    }
}
