using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5_Inciso_2 //** Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos. **//

{
    class Program
    {
        static void Main(string[] args) //Método Main;
        {
            int Figura;
            do
            {
                Console.WriteLine("| ¿A qué figura le desea calcular el área?|");
                Console.WriteLine("| 1) Circulo | 2) Cuadrado | 3) Triangulo |");
                Console.Write("Opcion: ");
                Figura = Convert.ToInt32(Console.ReadLine());
            }

            while ((Figura < 1) || (Figura > 3)); // Asignamos un ciclo while para volver a correr la aplicación / solicitud;
            {
                switch (Figura)
                {
                    case 1:
                        Area_Circulo(); // Solo asignamos el metodo, este hará su labor;
                        break;
                    case 2:
                        Area_Cuadrado(); // Solo asignamos el metodo, este hará su labor;
                        break;
                    case 3:
                        Area_Triangulo(); // Solo asignamos el metodo, este hará su labor;
                        break;
                }
            }
        }
        static void Area_Circulo() //Método para el area del circulo; 
        {
            double Radio, Resultado_Area_Circulo;
            const double Pi = 3.1416;

            Console.Write("Radio: ");
            Radio = Convert.ToDouble(Console.ReadLine());
            
            Resultado_Area_Circulo = Pi * (Radio * Radio);
            Console.WriteLine("El área es {0}", Resultado_Area_Circulo);

            Console.ReadKey();
        }
        static void Area_Cuadrado() //Método para el area del cuadrado; 
        {
            double Base_Cuadrado, Altura_Cuadrado, Resultado_Area_Cuadrado;

            Console.Write("Base: ");
            Base_Cuadrado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            Altura_Cuadrado = Convert.ToDouble(Console.ReadLine());

            Resultado_Area_Cuadrado = Base_Cuadrado * Altura_Cuadrado;
            Console.WriteLine("El área es {0}", Resultado_Area_Cuadrado);

            Console.ReadKey();
        }
        static void Area_Triangulo() //Método para el area del triangulo; 
        {
            double Base_Triangulo, Altura_Triangulo, Resultado_Area_Triangulo;

            Console.Write("Base: ");
            Base_Triangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            Altura_Triangulo = Convert.ToDouble(Console.ReadLine());

            Resultado_Area_Triangulo = (Base_Triangulo * Altura_Triangulo) / 2;
            Console.WriteLine("El área es {0}", Resultado_Area_Triangulo);

            Console.ReadKey();
        }
    }
}
