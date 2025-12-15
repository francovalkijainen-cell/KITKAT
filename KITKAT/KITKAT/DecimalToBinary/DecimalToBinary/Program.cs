using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("sisesta number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            string result = string.Empty;
            
            for (int i = 0; num > 0; i++)
            {
                result = num % 2 + result;
                num = num / 2;
            }
            Console.WriteLine($"Binary Number: {result}");
            Console.ReadLine();

        }
    }
}
