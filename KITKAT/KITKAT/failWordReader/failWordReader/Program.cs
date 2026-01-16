using System.Linq.Expressions;

namespace failWordReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luuletus");


            Console.WriteLine("Luuletus");
            FileWordReader();
        }

        static void FileWordReader()
        {
            string line;

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/luuletus.txt"))
                {
                    int cnt = 0; //rea muutuja
                    while (sr.EndOfStream == false)
                    {
                        ++cnt; //rea nr suurendamine
                        line = sr.ReadLine();//teksti lugemine
                        int pikkus = line.Length; //sõna lugemine
                        Console.WriteLine(cnt + " " + line + " " + pikkus);

                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("faili ei saa lugeda");
                Console.WriteLine(e.Message);

                throw;
            }

        }

    }
}


