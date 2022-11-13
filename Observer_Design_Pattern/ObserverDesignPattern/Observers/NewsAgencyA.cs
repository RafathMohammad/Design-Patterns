using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observers
{
    class NewsAgencyA : IObserver
    {
        public void Update(ISubject subject)
        {
            WeatherStation weatherStation = subject as WeatherStation;
            if (weatherStation != null)
            {
                Console.WriteLine("NewsAgencyA Displaying the Temperature {0} Degree Celcius", weatherStation.Temperature);
            }
        }
    }
}
