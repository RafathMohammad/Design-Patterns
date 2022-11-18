using AbstractFactoryDesignpattern.Interfaces;

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
