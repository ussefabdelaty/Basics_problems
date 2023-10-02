/*To implement a bubble sort algorithm in C#
 * Create a method that takes an array of integers as a parameter. This method will perform the bubble sort.

* In a loop that iterates for a number of times equal to the length of the array, do the following:

a. In an inner loop, iterate through the array from the beginning to the second-to-last element.

b. Compare each element with its adjacent element. If the current element is greater than the next element, swap them.

* After each pass through the array in the inner loop, the largest unsorted element will have "bubbled up" to the end of the array.

Repeat the process until no more swaps are needed in a pass, which means the array is fully sorted.
 */
namespace Bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayToBubbleSort = { 10,65 ,178 ,30,23,14,9,18 };

            ApplyBubble obj = new ApplyBubble();

            obj.ForBubble(ArrayToBubbleSort);
            
            obj.PrintArray(ArrayToBubbleSort);  
            Console.WriteLine();
        }
    }

    public class ApplyBubble
    {
        public void ForBubble(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i =0; i<n-1; i++)
            {
                swapped = false; 

                for(int j = 0; j< n-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int target = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = target;    
                        swapped = true;

                    }   
                }
                if (!swapped)
                    break;
            }
        }

        public void PrintArray (int[] arr)
        {
            foreach (int i in arr )
            {
                Console.Write(i + " ");
            }
        }

    }
}