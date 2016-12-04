using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature (Farenheit): ");
            float originalFahrenheit = float.Parse(Console.ReadLine());

            Console.Write("Enter temperature (Celsius): ");
            float originalCelsius = float.Parse(Console.ReadLine());

            //Fahrenheit to Celsius
            float Celsius = ((originalFahrenheit - 32) / 9) * 5;
            float Fahrenheit = ((originalCelsius * 9) / 5) + 32;

            Console.WriteLine(originalFahrenheit.ToString() + " degree Fahrenheit is " + Celsius.ToString() + " degree Celsius.");
            Console.WriteLine(originalCelsius.ToString() + " degree Celsius is " + Fahrenheit.ToString() + " degree Fahrenheit.");



        }
    }
}
