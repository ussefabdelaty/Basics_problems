using System.Linq.Expressions;
using System.Reflection;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the elements of array to sort them assending!");
            string array = Console.ReadLine();
            string[] array_s = array.Split(',');
            int[] array_i = new int[array_s.Length];
            for (var i= 0; i < array_i.Length;i++)
            {
                array_i[i] = Convert.ToInt32(array_s[i]);
            }
            BubbleSortArr(array_i);
            PrintArray(array_i);

        }

        static void BubbleSortArr(int[] array_i )
        {
            int n = array_i.Length;
            for (int i = 0; i < array_i.Length -1; i++)
            {
                // Outer loop - for number of passes
                for (int j = 0; j < n - i -1; j++)
                {
                    // Inner loop - for comparing and swapping
                    if (array_i[j] > array_i[j + 1])
                    {
                        // Swap elements if out of order
                        int swap = array_i[j];
                        array_i[j] = array_i[j + 1];
                        array_i[j + 1] = swap;
                    }
                }
            }
        }
        static void PrintArray(int[] array_i)
        {
            foreach(int element in array_i)
            {
                Console.Write(element + " ");
            }
           
        }
    }
}
