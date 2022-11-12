using AbstractFactoryDesignpattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern.Interfaces
{
    interface ICompanyAsset
    {
        ILaptop GetLaptop();
        IHeadset GetHeadset();
        IDesktop GetDesktop();
    }
}
