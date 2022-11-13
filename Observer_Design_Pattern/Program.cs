using ObserverDesignPattern.Interfaces;
using ObserverDesignPattern.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();
            MobileA mobileA = new MobileA();
            MobileB mobileB = new MobileB();
            NewsAgencyA newsAgencyA = new NewsAgencyA();
            NewsAgencyB newsAgencyB = new NewsAgencyB();

            weatherStation.Add(mobileA);
            weatherStation.Add(mobileB);
            weatherStation.Add(newsAgencyA);
            weatherStation.Remove(mobileA);
            weatherStation.Add(newsAgencyB);

            Random random = new Random();
            weatherStation.Temperature = random.Next(20, 30);
            weatherStation.Temperature = random.Next(20, 30);
            weatherStation.Temperature = random.Next(20, 30);
            weatherStation.Temperature = random.Next(20, 30);

            weatherStation.Remove(newsAgencyA);
            Console.ReadLine();
        }
    }
}
