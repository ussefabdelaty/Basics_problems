namespace Reverse_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter number of array seperated by ','");
            string input_numbers = Console.ReadLine();
            string [] slices = input_numbers.Split(',');
            int[] numbers_array = new int[slices.Length];
            for (var i = 0; i< numbers_array.Length; i++)
            {
                numbers_array[i] = Convert.ToInt32(slices[i]);
            }

            int left = 0;
            int right = numbers_array.Length - 1;
            while (left < right)
            {
                int swap = numbers_array[left];
                numbers_array[left] = numbers_array[right];
                numbers_array[right] = swap;
                left++;
                right--;
            }
            Console.WriteLine("the reverse of array");
            Console.WriteLine(string.Join(",", numbers_array));

        }
    }
}
