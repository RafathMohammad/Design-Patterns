using AbstractFactoryDesignpattern.Interfaces;
using AbstractFactoryDesignpattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Factories
{
    class HPCompany : ICompanyAsset
    {
            public IHeadset GetHeadset()
            {
                return new HPHeadset();
            }

            public ILaptop GetLaptop()
            {
                return new HPLaptop();
            }

            public IDesktop GetDesktop()
            {
                return new HPDesktop();
            }
    }
}
