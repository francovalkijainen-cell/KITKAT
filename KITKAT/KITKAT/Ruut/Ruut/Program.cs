namespace Ruut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teha for loopiga ruut
            int size;

            size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sisestage ruudu külje pikkus");

            double sideLength = Convert.ToDouble(Console.ReadLine());


            double area = sideLength * sideLength;


            double circumference = 4 * sideLength;

            Console.WriteLine($"Ruudu pindala on: {area}");
            Console.WriteLine($"Ruudu ümbermõõt on: {circumference}");

            Console.ReadKey();
        }
    }
}

