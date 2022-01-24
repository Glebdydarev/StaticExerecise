using System;

namespace StaticExerecise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);


            Console.WriteLine("After conversion");

            Console.WriteLine($"celsius{celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
