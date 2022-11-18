using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Observers
{
    class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public float Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                Console.WriteLine();
                Console.WriteLine("Temperature has been changed");
                Console.WriteLine("--------------------------------------------");
                Notify();
            }
        }
        private float _temperature;
        public void Add(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine("observer has been added");
        }
        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine("observer has been removed");
        }
        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
