using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Factorial de un número\n");
            Console.WriteLine("Continuar:1\nSalir:2\n");
            int respuesta = int.Parse(Console.ReadLine());
  
            switch (respuesta)
            {
                case 1:
                    int x = 1;
                    while (x <= 100)
                    {
                        do
                        {
                            Console.Write("Digite un número: ");
                            num = int.Parse(Console.ReadLine());
                            verificar(num);
                        } while (num < 0);
                        factorial(num);
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Presiones una tecla para salir");
                    Console.ReadKey();
                    break;
            }


        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo\n");
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

