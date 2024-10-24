namespace Inloggningssytem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            while (true)
            {
                TimeSpan AdminTime = new TimeSpan(600);

                Console.WriteLine("1. Lägg till användare");

                Console.WriteLine("2. Inställningar");

                Console.WriteLine("3. Avsluta");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        Console.WriteLine("1. Byt till slumpmässig textfärg");

                        Console.WriteLine("2. Ändra konsolfönstrets titel");

                        break;
                    case "3":
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Fel menyval");
                        break;
                }

            }

            while (true)
            {
                Console.WriteLine("1. Visa lösenord");

                Console.WriteLine("2. Avsluta");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Fel menyval");
                        break;
                }
            }
        }
    }
}
