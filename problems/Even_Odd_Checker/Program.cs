namespace Even_Odd_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to check it even or odd");
            var x = int.Parse(Console.ReadLine());
            if (x % 2 == 0 )
            {
                Console.WriteLine("Even!");
            }
            else 
            {
             Console.WriteLine("Odd!");
            }
            Console.ReadKey();  

        }
    }
}