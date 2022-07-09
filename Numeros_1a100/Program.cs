using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_1a100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            for (numero = -1; numero < 100; numero++)
            {
                numero = numero + 1;
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
