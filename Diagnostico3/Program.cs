namespace Diagnostico3
{
    
 using System;


class Program

        {

            static void Main()

            {

                Console.Write("Ingrese la cantidad de números primos en la serie de Fibonacci: ");

                if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)

                {

                    FibonacciPrimos(cantidad);

                }

                else

                {

                    Console.WriteLine("Entrada inválida. Ingrese un número positivo.");

                }

            }

            static void FibonacciPrimos(int cantidad)

            {

                int a = 0, b = 1, contador = 0;

                while (contador < cantidad)

                {

                    if (EsPrimo(a))

                    {

                        Console.Write(a + " ");

                        contador++;

                    }

                    (a, b) = (b, a + b); // Calcula la secuencia de Fibonacci

                }

            }

            static bool EsPrimo(int num)

            {

                if (num < 2) return false;

                for (int i = 2; i * i <= num; i++)

                    if (num % i == 0) return false;

                return true;

            }

        }


    }


