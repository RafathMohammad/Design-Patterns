using AbstractFactoryDesignpattern.Interfaces;
using AbstractFactoryDesignpattern.Products;

namespace AbstractFactoryDesignpattern.Factories
{
    class HPCompany : IAbstractFactory
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
