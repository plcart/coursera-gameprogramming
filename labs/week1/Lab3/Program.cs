using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature (Fahrenheit): ");
            float originalFahrenheit = float.Parse(Console.ReadLine());
            float toCelsius = ((originalFahrenheit - 32) / 9) * 5;
            float toFahrenheit = toCelsius * 9 / 5 + 32;
            Console.WriteLine("{0:f2} degrees Fahrenheit is {1:f2} degrees Celsius",originalFahrenheit,toCelsius);
            Console.WriteLine("{0:f2} degrees Celsius is {1:f2} degrees Fahrenheit", toCelsius, toFahrenheit);
            Console.Read();
        }
    }
}
