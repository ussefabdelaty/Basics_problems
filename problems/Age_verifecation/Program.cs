using System.ComponentModel.DataAnnotations;

namespace Age_verifecation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            var x = int.Parse(Console.ReadLine());
            if (x >= 18 & x > 0)
            {
                Console.WriteLine("you are An Adult!");
            }
            else if (x < 0)
                Console.WriteLine("please enter a positive number");
            else
            {
                Console.WriteLine("you still not adult yet!");
            }

            Console.ReadKey();
        }
    }
}