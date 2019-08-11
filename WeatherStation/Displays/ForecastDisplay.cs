using System;

namespace WeatherStation
{
    class ForecastDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private IDisposable unsubscriber;
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.Subscribe(weatherData);
        }

        public void Subscribe(WeatherData weatherData)
        {
            this.unsubscriber = weatherData.Subscribe(this);
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void Unsubscribe()
        {
            this.unsubscriber.Dispose();
        }

        public void OnError(Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }

        public void OnNext(WeatherData weatherData)
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.Pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}

