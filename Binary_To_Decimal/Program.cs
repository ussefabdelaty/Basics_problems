namespace Binary_To_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter binary number you want to convert to decimal");
            string binarystr=Console.ReadLine();
            string[] binaryarr = binarystr.Split(' ');

            //GetNumericValue: It’s a built-in method in C#
            int[] binarynum = Array.ConvertAll(binarystr.ToCharArray(), c=> (int)char.GetNumericValue(c));

            int total , power;
            total = 0;
            power = 0;
            for (int  i = binarynum.Length - 1; i >= 0;i --)
            {
                total += binarynum[i] * (int)Math.Pow(2, power);
                power++;
            }
            Console.WriteLine($"the number after convert to decimal = {total}");
        }
    }
}
