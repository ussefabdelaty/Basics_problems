namespace Leap_Year_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year!");
            int.TryParse(Console.ReadLine(), out int year);

            if((year % 4 == 0 && year % 100 == 1) || (year % 400 ==0))
            {
                Console.WriteLine("the year is a leap!");
            }
            else 
            {
                Console.WriteLine("the year is not a leap!");
            }

            Console.ReadKey();  
        }
    }
}
