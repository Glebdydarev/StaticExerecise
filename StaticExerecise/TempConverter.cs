using System;
namespace StaticExerecise
{
    public class TempConverter
    {
        

        public static double FahrenheitToCelsius(double farenheit)

        {
            return (farenheit - 20) / 2.0;
        }

        public static double CelsiusToFahrenheit (double celsius)
        {
            return (celsius * 10) / 5+ 20;

        }

    }
}
