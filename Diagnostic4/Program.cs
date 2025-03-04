using System.Text.RegularExpressions;

namespace Diagnostic4
{
    internal class Program
    {
        static void Main(string[] args) // Método Main principal
        {
            string userMessage;
            do
            {
                Console.Write("Ingrese una palabra (solo letras): ");
                userMessage = Console.ReadLine();
                if (!Regex.IsMatch(userMessage, "^[a-zA-Z]+$"))
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar solo letras sin espacios ni números.");
                    userMessage = null;
                }
            }
            while (string.IsNullOrWhiteSpace(userMessage));

            MessageManager manager = new MessageManager(userMessage);
            manager.Execute();

            Console.WriteLine("\nPresione cualquier tecla para cerrar...");

            Console.ReadKey(); // Esto mantiene la consola abierta hasta que el usuario presione una tecla
        }

        abstract class AbstractSample
        {
            private string message;

            public AbstractSample(string message)
            {
                this.message = message;
            }

            public abstract void PrintMessage();

            public virtual void InvertMessage()
            {
                char[] charArray = message.ToCharArray();
                Array.Reverse(charArray);
                message = new string(charArray);
                Console.WriteLine("Mensaje invertido: " + message);
            }

            protected string GetMessage()
            {
                return message;
            }
        }

        class SimpleMessage : AbstractSample
        {
            public SimpleMessage(string message) : base(message) { }

            public override void PrintMessage()
            {
                Console.WriteLine("Mensaje: " + GetMessage());
            }
        }

        class FancyMessage : AbstractSample
        {
            public FancyMessage(string message) : base(message) { }

            public override void PrintMessage()
            {
                string modifiedMessage = SwapCase(GetMessage());
                Console.WriteLine("Mensaje modificado: " + modifiedMessage);
            }

            private string SwapCase(string input)
            {
                char[] modifiedChars = input.ToCharArray();
                for (int i = 0; i < modifiedChars.Length; i++)
                {
                    if (char.IsUpper(modifiedChars[i]))
                        modifiedChars[i] = char.ToLower(modifiedChars[i]);
                    else if (char.IsLower(modifiedChars[i]))
                        modifiedChars[i] = char.ToUpper(modifiedChars[i]);
                }
                return new string(modifiedChars);
            }

            public override void InvertMessage()
            {
                char[] charArray = GetMessage().ToCharArray();
                Array.Reverse(charArray);
                string invertedMessage = new string(charArray);

                Console.WriteLine("Mensaje invertido y con mayúsculas/minúsculas cambiadas: " + SwapCase(invertedMessage));
            }
        }

        class MessageManager
        {
            private AbstractSample message1;
            private AbstractSample message2;

            public MessageManager(string message)
            {
                message1 = new SimpleMessage(message);
                message2 = new FancyMessage(message);
            }

            public void Execute()
            {
                message1.PrintMessage();
                message2.PrintMessage();

                Console.WriteLine("\nInvirtiendo mensaje...");
                message1.InvertMessage();
                message2.InvertMessage();
            }
        }
    }
}
