namespace sum_elements_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter numbers of array to sum ");
            string inputNum = Console.ReadLine();
            int[] numbers = inputNum.Split(',').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (var n in numbers)
            {
               
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
