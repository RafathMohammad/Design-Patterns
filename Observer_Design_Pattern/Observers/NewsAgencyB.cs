using ObserverDesignPattern.Interfaces;
using System;

namespace ObserverDesignPattern.Observers
{
    class NewsAgencyB : IObserver
    {
        public void Update(ISubject subject)
        {
            WeatherStation weatherStation = subject as WeatherStation;
            if (weatherStation != null)
            {
                Console.WriteLine("NewsAgencyB Displaying the Temperature {0} Degree Celcius", weatherStation.Temperature);
            }
        }
    }
}
