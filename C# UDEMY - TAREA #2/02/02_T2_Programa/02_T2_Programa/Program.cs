using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T2_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa transforme de grados Celsius a grados Fahrenheit.");

            float Grados_Celsius, Grados_Fahrenheit;

            Console.Write("Temperatura en Celsius: ");
            Grados_Celsius = Convert.ToSingle(Console.ReadLine());

            Grados_Fahrenheit = (Grados_Celsius * 1.8f) + 32;

            Console.WriteLine("{0}°C = {1}°F", Grados_Celsius, Grados_Fahrenheit);
        }
    }
}
