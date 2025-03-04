namespace Diagnostic2
{
    internal class Program
    {
        static void Main()

        {

            int numeroGanador = 2345; // Número ganador fijo

            // Lista de permutaciones del número 2345

            string[] permutaciones2345 = {

            "2345", "2354", "2435", "2453", "2534", "2543",

            "3245", "3254", "3425", "3452", "3524", "3542",

            "4235", "4253", "4325", "4352", "4523", "4532",

            "5234", "5243", "5324", "5342", "5423", "5432"

        };

            int numeroApostado;

            int montoApostado;

            // Solicitar número y validar que sea un entero de 4 cifras

            while (true)

            {

                Console.Write("Ingrese su número de 4 dígitos: ");

                string inputNumero = Console.ReadLine();

                if (int.TryParse(inputNumero, out numeroApostado) && inputNumero.Length == 4)

                    break;

                else

                    Console.WriteLine("Número inválido. Debe ser un número de 4 dígitos.");

            }

            // Solicitar monto y validar que sea un número entero positivo

            while (true)

            {

                Console.Write("Ingrese el monto apostado: ");

                string inputMonto = Console.ReadLine();

                if (int.TryParse(inputMonto, out montoApostado) && montoApostado > 0)

                    break;

                else

                    Console.WriteLine("Monto inválido. Debe ser un número positivo.");

            }

            int premio = 0; // Ganancia inicial

            // Primera verificación: número exacto

            if (numeroApostado == numeroGanador)

            {

                premio = montoApostado * 4500;

                Console.WriteLine("¡Felicidades! Acertaste los 4 dígitos en orden.");

            }

            // Segunda verificación: revisar si está en las permutaciones

            else if (Array.Exists(permutaciones2345, num => num == numeroApostado.ToString()))

            {

                premio = montoApostado * 200;

                Console.WriteLine("¡Felicidades! Acertaste los 4 dígitos en desorden.");

            }

            // Tercera verificación: últimas 3 cifras

            else if (numeroApostado.ToString().Substring(1) == numeroGanador.ToString().Substring(1))

            {

                premio = montoApostado * 400;

                Console.WriteLine("¡Acertaste las últimas 3 cifras!");

            }

            // Cuarta verificación: últimas 2 cifras

            else if (numeroApostado.ToString().Substring(2) == numeroGanador.ToString().Substring(2))

            {

                premio = montoApostado * 50;

                Console.WriteLine("¡Acertaste las últimas 2 cifras!");

            }

            // Quinta verificación: última cifra

            else if (numeroApostado.ToString().Substring(3) == numeroGanador.ToString().Substring(3))

            {

                premio = montoApostado * 5;

                Console.WriteLine("¡Acertaste la última cifra!");

            }

            else

            {

                Console.WriteLine("Lo siento, no ganaste esta vez.");

            }

            // Mostrar el premio final

            Console.WriteLine("Ganancia total: $" + premio);
        }
    }
}
