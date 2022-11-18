using ObserverDesignPattern.Interfaces;
using System;

namespace ObserverDesignPattern.Observers
{
    class MobileB : IObserver
    {
        public void Update(ISubject subject)
        {
            WeatherStation weatherStation = subject as WeatherStation;
            if (weatherStation != null)
            {
                Console.WriteLine("MobileB Displaying the Temperature {0} Degree Celcius", weatherStation.Temperature);
            }
        }
    }
}
