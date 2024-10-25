namespace Inloggningssytem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<user> users = new List<user>();
            Admin admin = new Admin();

            while (true)
            {
                bool menuAdmin = true;
                bool menuUser = true;
                string userInput;

                Console.Clear();

                Console.WriteLine("Inloggningssystem");

                Console.WriteLine("Användarnamn: ");
                string username = Console.ReadLine();

                Console.WriteLine("Lösenord: ");
                string password = Console.ReadLine();

                if (username == admin.UserName && password == admin.PassWord)
                {
                    DateTime adminDateTime = DateTime.Now;
                    TimeSpan duration = TimeSpan.FromMinutes(10);

                    while (menuAdmin)
                    {
                        TimeSpan elapsed = DateTime.Now - adminDateTime;
                        if (elapsed > duration)
                        {
                            Console.Clear();
                            Console.WriteLine("Max inloggingstid uppnådd. Du loggas ut.");
                            Thread.Sleep(2000);
                            menuAdmin = false;
                            break;
                        }

                        Console.Clear();

                        Console.WriteLine("1. Lägg till användare");

                        Console.WriteLine("2. Inställningar");

                        Console.WriteLine("3. Logga ut");

                        Console.WriteLine("4. Avsluta");

                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "1":
                                users.Add(new user());

                                break;
                            case "2":
                                Console.Clear();

                                Console.WriteLine("1. Byt till slumpmässig textfärg");

                                Console.WriteLine("2. Ändra konsolfönstrets titel");

                                userInput = Console.ReadLine();

                                switch (userInput)
                                {
                                    case "1":
                                        admin.BytTextFärg();
                                        break;
                                    case "2":
                                        admin.BytKonsolTitel();
                                        break;
                                    default:
                                        Console.WriteLine("Fel menyval");
                                        break;
                                }
                                break;
                            case "3":
                                menuAdmin = false;
                                break;

                            case "4":
                                System.Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fel menyval");
                                break;
                        }

                    }

                }

                foreach (var user in users)
                {
                    if (user.Namn() == username && user.Lösenord() == password)
                    {
                        DateTime userDateTime = DateTime.Now;
                        TimeSpan duration = TimeSpan.FromMinutes(2);

                        while (menuUser)
                        {
                            TimeSpan elapsed = DateTime.Now - userDateTime;
                            if (elapsed > duration)
                            {
                                Console.Clear();
                                Console.WriteLine("Max inloggingstid uppnådd. Du loggas ut.");
                                Thread.Sleep(2000);
                                menuUser = false;
                                break;
                            }

                            Console.Clear();

                            Console.WriteLine("1. Visa lösenord");

                            Console.WriteLine("2. Logga ut");

                            Console.WriteLine("3. Avsluta");

                            userInput = Console.ReadLine();

                            switch (userInput)
                            {
                                case "1":
                                    Console.WriteLine(user.Lösenord());
                                    break;
                                case "2":
                                    menuUser = false;
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
                }
            }
        }
    }
}