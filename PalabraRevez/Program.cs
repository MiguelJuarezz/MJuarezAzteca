using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraRevez
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la palabra a invertir");
            string cadena = Console.ReadLine();
            Console.WriteLine(Invertir(cadena));
            Console.ReadKey();
        }

        public static string Invertir(string cadena)
        {
            string cadenaInvertida = "";
            // Recorrer cadena letra por letra
            foreach (char letra in cadena)
            {
                // Anteponer la letra a la cadena invertida
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }
    }
}
