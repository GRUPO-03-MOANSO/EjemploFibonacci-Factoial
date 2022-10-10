using System;
namespace Ejemplo {
    internal class Program  {
        static void Main(string[] args) {
            int num = 5;
            Console.WriteLine("El factorial es: ");
            Console.WriteLine(Factorial(num));
            Console.WriteLine();

        }
        public static int Factorial(int numero) {
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
