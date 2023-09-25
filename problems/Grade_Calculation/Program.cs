namespace Grade_Calculation
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade (0-100):");

            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                string result;

                switch (grade / 10)
                {
                    case 10:
                    case 9:
                        result = "A";
                        break;
                    case 8:
                        result = "B";
                        break;
                    case 7:
                        result = "C";
                        break;
                    case 6:
                        result = "D";
                        break;
                    default:
                        result = "F";
                        break;
                }

                Console.WriteLine($"Your grade is {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.");
            }

            Console.ReadKey();
        }
    }

}
