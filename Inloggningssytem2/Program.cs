namespace Inloggningssytem2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void BytTextFärg()
        {
            Random random = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor randomColor = colors[Random.Next(colors.Leangth)];
            Console.ForgroundColor = randomColor;
            Console.WriteLine($"Textfärgen har ändrats till {randomColor}");
            Console.ResetColor();
            Console.WriteLine("Tryck på en valfri knapp för att fortsätta...");
            Console.ReadKey();
        }


        static void BytKonsolTitel()
        {
            Console.WriteLine("Ange ny titel för konsolfönstret: ");
            string nyTitel = Console.ReadLine();
            Console.Titel = nyTitel;
            Console.WriteLine($"Konsolfönstrets titel har ändrats till \"{nyTitel}\"");
            Console.WriteLine("Tryck på valfri knapp för att fortsätta...");
            Console.ReadKey();
        }
    }
}
