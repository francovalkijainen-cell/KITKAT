using System.ComponentModel.Design;

namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Asteriks");

            int nr = Convert.ToInt32(Console.ReadLine());

            //tuleb kasutada for loopi
            //sisestan ridade arvu ja tuleb vastav ridade arv konsooli
            //peab naitama tärne
            for (int i = 0; i < nr; i++)
            {
                if (i == i)
                {
                    Console.WriteLine("*");

                }
                else
                {
                    Console.WriteLine(" ");
                }


            }
        }
    }
}

