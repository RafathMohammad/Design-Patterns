using AbstractFactoryDesignpattern.Interfaces;
using AbstractFactoryDesignpattern.Products;

namespace AbstractFactoryDesignpattern.Factories
{
    class DellCompany : IAbstractFactory
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
