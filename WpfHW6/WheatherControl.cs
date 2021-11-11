using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfHW6
{
    class WheatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty;
        string[] windDirection = { "Северный", "Южный", "Восточный", "Западный" };
        Random random = new Random();

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
            set => SetValue(TemperatureProperty, value);
        }

        static WheatherControl()
        {
            TemperatureProperty = DependencyProperty.Register(
                nameof(Temperature),
                typeof(int),
                typeof(WheatherControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.None,
                    null,
                    new CoerceValueCallback(CoerceTemperature)),
                new ValidateValueCallback(ValidateTemperature));
        }

        private static bool ValidateTemperature(object value)
        {
            int v = (int)value;
            if (v >= -50 && v <= 50)
            {
                return true;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v>=-50 && v<= 50)
            {
                return true;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public string TemperatureRange()
        {
            int temperatureRange = random.Next(-50, 50);
            return temperatureRange.ToString();
        }

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
