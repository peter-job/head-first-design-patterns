using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStation.Net
{
    class CurrentConditionsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private IDisposable unsubscriber;
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(IObservable<WeatherData> weatherData)
        {
            weatherData.Subscribe(this);
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            this.unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void Unsubscribe()
        {
            this.unsubscriber.Dispose();
        }

        public void OnNext(WeatherData weatherData)
        {
            this.temperature = weatherData.Temperature;
            this.humidity = weatherData.Humidity;
            Display();
        }

        public void OnError(Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0:F1}C degrees and {1:F0}% humidity", temperature, humidity));
        }
    }
}


