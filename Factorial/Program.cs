using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Calculo del Factorial de un número entero positivo del 1 al 100\n");

            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                num = int.Parse(Console.ReadLine());
                verificar(num);
            } while (num < 0 || num > 100);
            factorial(num);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0 || n > 100)
            {
                Console.Write("\nError: No existe el factorial de un número negativo o esta fueran del rango de 1-100..\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}
