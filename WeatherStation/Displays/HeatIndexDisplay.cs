﻿using System;

namespace WeatherStation
{
    class HeatIndexDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private IDisposable unsubscriber;
        private float temperature;
        private float humidity;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this.Subscribe(weatherData);
        }

        public void Subscribe(WeatherData weatherData)
        {
            this.unsubscriber = weatherData.Subscribe(this);
        }

        public void OnNext(WeatherData weatherData)
        {
            this.temperature = weatherData.Temperature;
            this.humidity = weatherData.Humidity;
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

        private float computeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Heat index is {0:F1}", computeHeatIndex(temperature, humidity)));
        }
    }
}


