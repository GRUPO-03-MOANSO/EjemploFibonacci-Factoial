
using System;
namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("El factorial es: ");
            Console.WriteLine(Factorial(num));
            Console.WriteLine();

            Console.WriteLine("El resultado de la suma es: ");
            Console.WriteLine(NumeroFibonacci(num));
            Console.ReadLine();

        }

        //FIBONACCI
        public static int NumeroFibonacci(int posicion)
        {

            if (posicion > 0)
            {
                int num1 = 0, num2 = 1, suma = 0;
                for (int i = 1; i < posicion; i++)
                {
                    suma = num1 + num2;
                    num1 = num2;
                    num2 = suma;
                }
                return suma;
            }
            else
            {
                return -1;
            }
        }

        //FACTORIAL
        public static int Factorial(int numero)
        {
            if (numero > 0)
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
            return -1;

        }

    }
}