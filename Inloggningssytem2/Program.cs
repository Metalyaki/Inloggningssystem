namespace Inloggningssytem2
{
    internal class Program
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }


        public Program(string adminUsernNme, string adminPassWord)
        {
            UserName = adminUsernNme;
            PassWord = adminPassWord;
        }
        static void BytTextFärg()
        {
            Random random = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor randomColor = colors[random.Next(colors.Length)];
            Console.ForegroundColor = randomColor;
            Console.WriteLine($"Textfärgen har ändrats till {randomColor}");
            Console.ResetColor();
            Console.WriteLine("Tryck på en valfri knapp för att fortsätta...");
            Console.ReadKey();
        }

        static void BytKonsolTitel()
        {
            string userInput;

            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            if(username == admin.username && password == admin.password)
            {
                while (true)
                {
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

            }

            if(username == user.username && password == user.password)
            {
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
}