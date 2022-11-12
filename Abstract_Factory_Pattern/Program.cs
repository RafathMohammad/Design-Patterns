using AbstractFactoryDesignpattern.Factories;
using AbstractFactoryDesignpattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignpattern
{
    class Client
    {
        public void Main(int role)
        {
            switch (role)
            {
                case 1:
                    ManagerHandoverSystem(new DellCompany());
                    HandoverHeadset(new HPCompany());
                    break;
                case 2:
                    HandoverSystem(new HPCompany());
                    HandoverHeadset(new DellCompany());
                    break;
                case 3:
                    ManagerHandoverSystem(new DellCompany());
                    HandoverHeadset(new HPCompany());
                    break;
                case 4:
                    HandoverSystem(new HPCompany());
                    HandoverHeadset(new DellCompany());
                    break;
                default:
                    Console.WriteLine("Please enter your role Correctly");
                    break;

            }
               
        }
        public void ManagerHandoverSystem(ICompanyAsset asset)
        {
            
            var laptop=asset.GetLaptop();
            Console.WriteLine(laptop.Handover());
            
        }
        public void HandoverSystem(ICompanyAsset asset)
        {
            var desktop = asset.GetDesktop();
            Console.WriteLine(desktop.Handover());
        }
        public void HandoverHeadset(ICompanyAsset asset)
        {
            var headset = asset.GetHeadset();
            Console.WriteLine(headset.Handover());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client();
            Console.WriteLine("enter 1 : manager and permanent employee");
            Console.WriteLine("enter 2 : Not a manager and permanent employee");
            Console.WriteLine("enter 3 : manager and Contract employee");
            Console.WriteLine("enter 4 : Not a manager and permanent employee");
            client.Main(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}


