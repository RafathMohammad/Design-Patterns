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
