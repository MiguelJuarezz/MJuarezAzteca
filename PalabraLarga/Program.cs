using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraLarga
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Encontrar la palabra mas larga");
            Console.WriteLine("Ingresa la cadena");

            string cadena = Console.ReadLine();
            string[] palabras = cadena.Split();

            string palabraLarga = "";
            
            foreach (string palabra in palabras)
            {
                if (palabra.Length>palabraLarga.Length)
                {
                    palabraLarga = palabra;

                }
            }
            Console.WriteLine("La palabra mas larga es: " + palabraLarga);
            Console.ReadKey();
              
        }
    }
}
