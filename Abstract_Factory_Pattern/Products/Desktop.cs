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
