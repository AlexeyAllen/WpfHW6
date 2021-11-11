using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfHW6
{
    public class WheatherControl : DependencyObject
    {
        string[] windDirection = { "Северный", "Южный", "Восточный", "Западный" };
        Random random = new Random();

        public static readonly DependencyProperty.TemperatureProperty;

        public enum Precipitations
        {
            солнечно,
            облачно,
            дождливо,
            снег
        }

        public int Temperature
        {
            get => (int)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty);
        }







        //public string TemperatureRange()
        //{
        //    int temperatureRange = random.Next(-50, 50);
        //    return temperatureRange.ToString();
        //}

        public string WindDirection()
        {
            int indexWind = random.Next(windDirection.Length);
            return windDirection[indexWind];
        }

        public string WindSpeed()
        {
            int windSpeed = random.Next(0, 20);
            return windSpeed.ToString();
        }

        public string WeatherPrecipit()
        {
            Type type = typeof(Precipitations);
            Array values = type.GetEnumValues();
            int indexPrecipit = random.Next(values.Length);
            Precipitations value = (Precipitations)values.GetValue(indexPrecipit);
            return value.ToString();
        }
    }
}
