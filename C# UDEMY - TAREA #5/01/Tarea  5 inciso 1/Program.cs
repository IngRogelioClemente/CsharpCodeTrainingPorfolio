using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__5_inciso_1 //**Crear un método para transformar de grados a radianes**//
{
    class Program
    {
        // [modificador] [tipo] [identificador] [parametros]
        static void Main(string[] args) //Método Main;
        {
            double Grados, Radianes;
          
            Console.Write("Introduzca los grados que desea transformar a radianes: ");
            Grados = Convert.ToDouble(Console.ReadLine());

            Radianes = Conversion(Grados); //Invoca al método de conversion copiando el parametro de grados que mandara al método a desarrollarse;
            Console.WriteLine("{0}° Grados son {1} Radianes", Grados, Radianes);

            Console.ReadKey();
        }
        // [modificador] [tipo] [identificador] [parametros]
        static double Conversion(double GradosOp) // Metodo que realiza la operacion de la conversion;
        {
            double RadianesOp;
            const double Pi = 3.1416;

            RadianesOp = (GradosOp * Pi) / 180;
            return RadianesOp; // Regresa el resultado obtenido;
        }
    }
}
