namespace Decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Decimal to Binary Conversion**: Create a program that converts a decimal number to its binary representation.

            Console.WriteLine("Hello, enter the number that you want ot convert it form decimal to binary!");
            string userinput = Console.ReadLine();
            string [] arrayofnum = userinput.Split(',');
            foreach (var n in arrayofnum)
            {
                int inputnumbers = Convert.ToInt32(n.Trim());
                var binarynumber = $"{inputnumbers}:as binary= {Convert.ToString(inputnumbers, 2).PadLeft(8, '0')}";
                Console.WriteLine(binarynumber);
            }
        }
    }
}
