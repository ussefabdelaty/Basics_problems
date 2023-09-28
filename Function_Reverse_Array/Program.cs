namespace Function_Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            TraverseArray(numbers);


            Console.WriteLine("the inverse of the array is: ");
            foreach (int number in numbers) 
            { 
                Console.Write( number + " ");  
            }
            Console.ReadKey();
        }

        //method for traverse 
        //i used "static cause it's in the main class that will be easily to call it directory without need an object"
        static void  TraverseArray(int[] array)
        {
            //pointers
            int left = 0;
            int right = array.Length - 1; 

            while (left < right)
            {
                //for swap the elemnts
                int pointer = array[left];
                array[left] = array[right];
                array[right] = pointer;

                //to move the pointers toward
                left++;
                right--;
            }
        }
    }
}