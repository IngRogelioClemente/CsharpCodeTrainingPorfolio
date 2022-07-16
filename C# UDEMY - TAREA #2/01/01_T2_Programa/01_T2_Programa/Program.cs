using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_T2_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el perímetro de cualquier polígono regular.

            //Declaración de variables tipo Double.
            double Perimetro, Num_Lados, Med_Lados;

            Console.WriteLine("Este programa calcula el perimetro de cualquier poligono regular.");

            //Entrada de valores.
            Console.Write("Introduce el numero de lados: "); 
            Num_Lados = Convert.ToDouble(Console.ReadLine()); //Se convierte directamente la string en double.

            Console.Write("Introduce la medida de los lados: ");
            Med_Lados = Convert.ToDouble(Console.ReadLine()); //Se convierte directamente la string en double.

            //Output de valores, se hace el calculo asignandolo a una variable double y se imprime en consola.
            Perimetro = Num_Lados * Med_Lados;

            Console.WriteLine("El perimetro del poligono es: {0}", Perimetro);

        }
    }
}
