namespace AnimalLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1. masiivi tegemine

            string[] animalName = { "koer,", "kass", "jänes", "sipelgas", "lendorav" };

            int longername = animalName[0].Length;
            string longerNameString = animalName[0];


            for (int i = 0; i < animalName.Length; i++)
            {
                if (longername == animalName[i].Length)
                {
                    longername = animalName[i].Length;
                    longerNameString = animalName[i];
                }

                int animalLength = AnimalLength(animalName[i]);
                Console.WriteLine(animalName[i] + " = ");
                Console.WriteLine(animalLength);
                Console.WriteLine();
            }
            Console.WriteLine("pikim nimi oli 0 ja mille nime pikkus oli: (1)",longerNameString,longername);
        }

        static int AnimalLength(string animalName)
        {
            return animalName.Length;
        }
    }
}






