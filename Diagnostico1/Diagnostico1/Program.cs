// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        int numeroGanador = 1234; // Número ganador predefinido

        Console.Write("Ingrese su número de 4 dígitos: ");

        int numeroApostado = Convert.ToInt32(Console.ReadLine());

        if (numeroApostado == numeroGanador)

        {

            Console.WriteLine("¡Felicidades! Ha ganado el sorteo.");

        }

        else

        {

            Console.WriteLine("Lo siento, no ha ganado esta vez.");

        }

    }

}
