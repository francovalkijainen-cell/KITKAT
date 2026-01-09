
namespace DigitalClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Digital Clock";
            Console.CursorVisible = false;

            while (true)
            {
                //// static method clears the console if possible.
                //Console.Clear();
                ////Converts the value of the current DateTime object
                ////to its equivalent string representation.

                //string time = DateTime.Now.ToString("HH:mm:ss");
                ////calculates the remaining space (in characters) in the
                ////console window after accounting for the length of a time string

                //int x = (Console.WindowWidth - time.Length) / 2;
                ////Gets or sets the height of the console window area.
                //int y = Console.WindowHeight / 2;
                ////Sets the position of the cursor.
                //Console.SetCursorPosition(x, y);
                ////Writes the text representation of the specified value
                ////or values to the standard output stream.
                //Console.Write(time);
                ////Suspends the current thread for the specified amount of time.
                //Thread.Sleep(1000);
                for (; ; )
                {
                    Console.Clear();
                    Console.WriteLine("Digital Clock\n");
                    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
