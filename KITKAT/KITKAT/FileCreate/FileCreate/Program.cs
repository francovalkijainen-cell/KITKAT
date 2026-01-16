namespace FileCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjutab faili läbi konsooli");

            string failpath = "C:/Users/opilane/Desktop/WriteToFile.txt";
            string input = Console.ReadLine();

            File.WriteAllText(failpath, input);
        }
    }
}
