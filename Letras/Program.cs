using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letras
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresa la cadena a sustituir");
            //string letras = "AFH";
            string letras = Console.ReadLine();
            string letrasSiguientes = "";

            foreach (char letra in letras)
            {
                char siguienteLetra = ObtenerSiguienteLetra(letra);
                letrasSiguientes += siguienteLetra;
            }

            Console.WriteLine(letrasSiguientes); // Imprime "BGI"
            Console.ReadKey();
        }

        static char ObtenerSiguienteLetra(char letra)
        {
            int codigoAscii = (int)letra;

            if (letra == 'Z')
            {
                // Si la letra es 'Z', el siguiente carácter es 'A'
                return 'A';
            }
            else if (codigoAscii >= 65 && codigoAscii <= 89)
            {
                // Si la letra es una mayúscula de la A a la Y, sumamos 1 al código ASCII
                return (char)(codigoAscii + 1);
            }
            else if (codigoAscii >= 97 && codigoAscii <= 121)
            {
                // Si la letra es una minúscula de la a a la y, sumamos 1 al código ASCII
                return (char)(codigoAscii + 1);
            }
            else
            {
                // En caso contrario, retornamos la misma letra sin cambios
                return letra;
            }
        }

    }
}






