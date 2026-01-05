namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //vaja teha string array H, e, l, l, o
            //kasuta for loopi

            string[] letters = { "H", "e", "l", "l", "o" };
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }
            string[] array = { "H", "e", "l", "l", "o" };
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
