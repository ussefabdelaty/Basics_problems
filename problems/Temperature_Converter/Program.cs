namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        { // converts temperatures between Celsius and Fahrenheit.
            Console.WriteLine("choose the kind of temperature you want to convert to:\n 1)celsius\n 2)Fahrenheit ");
            int.TryParse(Console.ReadLine(), out int TempKind);

            Console.WriteLine("enter the degree of the temperature!");
            double.TryParse(Console.ReadLine(), out double TempDegree);

            switch (TempKind)
            {
                case 1:
                    double celsuis = (TempDegree - 32) / (9.0 / 5.0);
                    Console.WriteLine("the temperature in celsuis=" + celsuis);
                    break;

                case 2:
                    double Fahrenheit = (TempDegree * 9.0 / 5.0) + 32;
                    Console.WriteLine("the temperature in celsuis=" + Fahrenheit);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}