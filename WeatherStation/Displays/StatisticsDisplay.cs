using System;

namespace WeatherStation
{
    class StatisticsDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private IDisposable unsubscriber;
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.Subscribe(weatherData);
        }

        public void Subscribe(WeatherData weatherData)
        {
            this.unsubscriber = weatherData.Subscribe(this);
        }

        public void OnNext(WeatherData weatherData)
        {
            this.Update(weatherData);
        }

        public void Update(WeatherData weatherData)
        {
            float temp = weatherData.Temperature;
            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
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

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings)
                + "/" + maxTemp + "/" + minTemp);
        }
    }
}


