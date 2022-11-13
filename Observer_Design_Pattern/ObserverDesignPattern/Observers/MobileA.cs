using ObserverDesignPattern.Interfaces;
using ObserverDesignPattern.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Observers
{
    class MobileA : IObserver
    {
        public void Update(ISubject subject)
        {
            WeatherStation weatherStation = subject as WeatherStation;
            if (weatherStation != null)
            {
                Console.WriteLine("MobileA Displaying the Temperature {0} Degree Celcius", weatherStation.Temperature);
            }
        }
    }
}
