namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //teie töö on te´ha switch rakendus,
            //kus on kolm case (1, 2, 3).
            //iga case puhul teeb erinev arv beep-e

             int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Beep(1000, 500);
                    break;
                case 2:
                    Console.Beep(1000, 500);
                    Console.Beep(2000, 500);
                    break;
                case 3:
                    Console.Beep(3000, 500);
                    Console.Beep(3000, 500);
                    Console.Beep(3000, 500);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
                
            }
        }
    } 
}
