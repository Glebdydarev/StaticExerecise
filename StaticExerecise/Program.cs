using System;

namespace StaticExerecise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(20);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(10);


            Console.WriteLine("After conversion");

            Console.WriteLine($"celsius{celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}
