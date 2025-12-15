using System.Runtime.ExceptionServices;

namespace FibonacciFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\n");
            Console.Write("näita esimest Fibanocci seeriat\n");
            Console.Write("------------------------------\n\n");
            Console.Write("Sisesta number");
        

            int prv = 0, pre = 1, trm, i, n;
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Siin on Fibonacci seeria {0} kuni \n", n);

            Console.Write($"{0} {1}", prv, pre);

            for (i = 3; i <= n; i++)
            {
                trm = prv + pre;
                Console.Write($"  {trm}");
                prv = pre;
                pre = trm;
            }
            Console.Write("\n");
        }
    }
}
