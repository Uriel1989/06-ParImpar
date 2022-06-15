using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int a;
              Console.WriteLine("Ingrese un numero entero: ");
              a = Convert.ToInt32(Console.ReadLine());
              if (a % 2 == 0)
              {
                  Console.WriteLine("El numero es par.");
              }
              else
              if (a % 2 != 0)
              {
                  Console.WriteLine("El numero es impar.");
              }
              Console.ReadKey();
          }*/

            for (int numero = 0; numero<=50; numero++)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " " + "es par.");
                }
                else if (numero %3== 0)
                {
                    Console.WriteLine("Fizz");
                }
            }
            Console.ReadKey();
        }
    }
}
