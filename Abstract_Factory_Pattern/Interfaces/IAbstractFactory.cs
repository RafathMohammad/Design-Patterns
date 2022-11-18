using AbstractFactoryDesignpattern.Products;

namespace AbstractFactoryDesignpattern.Interfaces
{
    interface IAbstractFactory
    {
        ILaptop GetLaptop();
        IHeadset GetHeadset();
        IDesktop GetDesktop();
    }
}
