using System.Xml.Schema;

namespace SwitchColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasvatab switchi
            //kuvab iga kord suvalised värvid
            //Red, Green, Blue, White, Orange
            //iga värvi puhul näitab vastava värviga konsooli
            Color color = (color)(new Random()).Next(0, 5);
           
            switch (color)
            {
                case color.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("´Red");
                    break;
                    case color.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Green");
                    break;
                    case color.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Blue");
                    break;
                    case color.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("White");
                    break;
                    case color.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Orange");
                    break;

            }

        }
    }
}
