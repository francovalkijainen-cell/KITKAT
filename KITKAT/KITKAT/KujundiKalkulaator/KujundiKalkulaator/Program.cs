namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. ringi raadius on 3 ühikut
            //leia ja väljesta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            int diameter = roundRadius * 2;
            double squareArea = diameter * diameter;
            double squarePerimeter = 4 * diameter;
            
            Console.WriteLine("Ruudu pindala:" + squareArea);
            Console.WriteLine("Ruudu ümbermõõt: " + squarePerimeter);

            //arvutada ringi pindala ja ümbermõõt
            //math.pi
            double CircleC = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi ümbermõõt on " + CircleC);

            double CircleS = Math.PI * (roundRadius * roundRadius);

            Console.WriteLine("ringi Pindala on " + CircleS);
        }
    }
}
