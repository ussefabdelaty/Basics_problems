namespace Pass_Checken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your password !");

            var x = int.Parse(Console.ReadLine());
            var y = 1234;

            if (x == y)
            {
                Console.WriteLine("access granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
            Console.ReadKey();
        }
    }
}