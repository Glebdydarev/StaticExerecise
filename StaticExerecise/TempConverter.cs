using System;
namespace StaticExerecise
{
    public class TempConverter
    {
        

        public static double FahrenheitToCelsius(double farenheit)

        {
            return (farenheit - 32) / 1.8;
        }

        public static double CelsiusToFahrenheit (double celsius)
        {
            return (celsius * 9) / 5 + 32;

        }

    }
}
