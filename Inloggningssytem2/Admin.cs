using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningssytem2
{
    internal class Admin
    {
        
        public string UserName { get; set; }
        public string PassWord { get; set; }


        public Admin()
        {
            UserName = "adminpenis";
            PassWord = "admin";
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
            Console.WriteLine("Ange ny titel för konsolfönstret: ");
            string nyTitel = Console.ReadLine();
            Console.Title = nyTitel;
            Console.WriteLine($"Konsolfönstrets titel har ändrats till \"{nyTitel}\"");
            Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
            Console.ReadKey();
        }
    }
}

    

