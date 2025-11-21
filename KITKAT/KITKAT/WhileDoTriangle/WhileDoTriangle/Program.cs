namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            //otsida internetist while koodiga kolmnurga kujundeid e tegemise viise
            //kui kood on leitud, siis kirjutada see siia alla
            //teha vooskeem

                // Outer loop for printing rows
                while (i <= n)
                {
                Console.WriteLine();
                    int j = 1;

                    // Inner loop for printing numbers in each row
                    while (j <= i)
                    {
                        Console.Write(j + " ");
                        j++;
                    }
                    i++;
                }
            
                Console.ReadKey();
        }
    }
}

