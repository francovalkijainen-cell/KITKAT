namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Saad valida enda meetodi, kui sisestad tähe");
            Console.WriteLine("a. Püramiidi kõrgus");
            Console.WriteLine("p. Teeb ruudu ja arvutab pindala/ümbermoodu");
            Console.WriteLine("q. Ruutvõrrand");
            string choice = Console.ReadLine();

            if (choice == "a")
            {
                Switch();
            }
            else if (choice == "p")
            {
                WhileLoop();
            }
            else if (choice == "q")
            {
                QuadraticFormula();
            }

            Console.WriteLine("ERROR");

            static void Switch()

            {
                Console.WriteLine("Mis on kolmnurga kõrgus?");

                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;

                while (i <= n)
                {
                    Console.WriteLine();
                    int j = 1;
                    while (j <= i)
                    {
                        Console.Write(j + " ");
                        j++;
                    }
                    i++;
                }

                Console.ReadKey();
            }
            static void WhileLoop()
            {

                Console.WriteLine("Sisesta ruudu suurus");

                int size = int.Parse(Console.ReadLine());

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n\n");

                int area = size * size;
                int around = 4 * size;
                Console.WriteLine("Pindala on " + area);
                Console.WriteLine("Ümbermõõt on " + around);
            }

            static void QuadraticFormula()
            {

                Console.WriteLine("Ruutvõrrand!");

                Console.Write("Sisesta a väärtus: ");
                double a  = double.Parse(Console.ReadLine());

                Console.Write("Sisesta p väärtus: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Sisesta q väärtus: ");
                double q = double.Parse(Console.ReadLine());

                Console.Write("Sisesta x väärtus: ");
                double p = double.Parse(Console.ReadLine());

        
                y = a * 3 - p * (2 + q);

                Console.WriteLine($"x1 = {(-p + Math.Sqrt(q)) / (2 * a)} , x2 = {(-p + Math.Sqrt(q)) / (2 * a)}");
                
            }
        }
    }
}
