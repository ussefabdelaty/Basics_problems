namespace Min_Max_number
{
   // a function that finds the maximum & minimum element in an array of integers.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,enter numbers with ',' split!");
            string userinputs = Console.ReadLine();
            string[] strarray = userinputs.Split(',');
            int[] numbers = new int[strarray.Length];
            for(var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(strarray[i]);
            }
            var minvalue = FindMin(numbers);
            var maxvalue = FindMax(numbers);
            Console.WriteLine($"the min value:{minvalue}");
            Console.WriteLine($"the min value:{maxvalue}");

        }

        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for(int i = 1; i <arr.Length; i ++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
