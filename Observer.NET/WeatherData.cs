using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Net
{
    class WeatherData : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<WeatherData>> _observers;
            private IObserver<WeatherData> _observer;

            public Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }


        public void RemoveObserver(IObserver<WeatherData> o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.OnNext(this));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        public float Temperature
        {
            get { return temperature; }
        }

        public float Pressure
        {
            get { return pressure; }
        }

        public float Humidity
        {
            get { return humidity; }
        }
    }
}
