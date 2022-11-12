using AbstractFactoryDesignpattern.Interfaces;
using AbstractFactoryDesignpattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Factories
{
    class DellCompany : ICompanyAsset
    {
            public IHeadset GetHeadset()
            {
                return new DellHeadset();
            }

            public ILaptop GetLaptop()
            {
                return new DellLaptop();
            }

            public IDesktop GetDesktop()
            {
                return new DellDesktop();
            }
    }
}
