namespace Ruutvõrrand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruutvõrrand!");

            //ax2 + bx + c

            //sisesta a, b ja c väärtus
            //kasutaja peab saama sisestada neid väärtuseid


                Console.WriteLine("Enter coefficients for ax^2 + bx + c = 0:");
                double a = GetCoefficient("a");
                double b = GetCoefficient("b");
                double c = GetCoefficient("c");

                if (a == 0)
                {
                    Console.WriteLine("Not a quadratic equation (a cannot be zero).");
                    return;
                }
                double discriminant = (b * b) - (4 * a * c);

                if (discriminant > 0) 
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Roots are real and distinct: {root1:F4} and {root2:F4}");
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine($"Roots are real and equal: {root:F4}");
                }
                else 
                {
                    double realPart = -b / (2 * a);
                    double imaginaryPart = Math.Sqrt(Math.Abs(discriminant)) / (2 * a);
                    Console.WriteLine($"Roots are complex: {realPart:F4} + {imaginaryPart:F4}i and {realPart:F4} - {imaginaryPart:F4}i");
                }
            }
            static double GetCoefficient(string name)
            {
                double value;
                Console.Write($"Enter value for {name}: ");
                while (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write($"Enter value for {name}: ");
                }
                return value;
            }
        }


    }


