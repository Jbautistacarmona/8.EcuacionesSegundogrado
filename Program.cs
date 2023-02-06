using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.EcuacionesSegundogrado
{
    internal class Program
    {
        static void Main(string[] args) //metodo.
        {
            Console.WriteLine("Calculadora de ecuaciones de segundo grado"); //mensaje en pantalla para elegir la opcion
            Console.WriteLine("Ingrese los coeficientes de la ecuación (a, b, c):");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;

            switch (discriminante) //selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión.
            {
                case double d when d > 0:
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a); //funcion matematica.
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    Console.WriteLine("La ecuación tiene dos soluciones reales x1 = {0} y x2 = {1}", x1, x2);
                    break;

                case double d when d == 0: //si cumple con los requisitos se realiza la operacion, 
                    double x = -b / (2 * a);
                    Console.WriteLine("La ecuación tiene una solución real x = {0}", x);
                    break; //salir de la funcion si se cumple el proceso.

                case double d when d < 0:
                    Console.WriteLine("La ecuación no tiene soluciones reales");
                    break;

                default:
                    Console.WriteLine("Error"); //sino se cumple ninguna, error y sale de la funcion, 
                    break;
            }
            Console.ReadLine(); //imprimir resultado en pantalla. 
        }
    }
}
