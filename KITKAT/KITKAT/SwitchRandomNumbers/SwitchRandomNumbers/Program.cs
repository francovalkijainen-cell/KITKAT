namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");

            //kõik kuus numbrit tuleb ära käsitleda switchiga 
            Random random = new Random();
            int number = random.Next(1, 7); // Genereerib arvu 1 kuni 6 (7 ei kuulu sisse)

            Console.WriteLine($"Genereeritud number: {number}");

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sa said ühe.");
                    break;
                case 2:
                    Console.WriteLine("Sa said kaks.");
                    break;
                case 3:
                    Console.WriteLine("Sa said kolm.");
                    break;
                case 4:
                    Console.WriteLine("Sa said neli.");
                    break;
                case 5:
                    Console.WriteLine("Sa said viis.");
                    break;
                case 6:
                    Console.WriteLine("Sa said kuus.");
                    break;
                default:
                    Console.WriteLine("Midagi läks valesti.");
                    break;



            }
        }
    }
}

