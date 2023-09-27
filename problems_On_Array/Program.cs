namespace problems_On_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers of array and split each number by space! ");
            string Input_Numbers_Array = Console.ReadLine();

            string[] Input_Numbers = Input_Numbers_Array.Split(',');

           int[] numbers = new int[Input_Numbers.Length];



           // int sum= 0;

            //foreach (string i in Input_Numbers)
            //{
            //    if (int.TryParse(i, out int numbers))
            //   {
            //        sum += numbers;
            //   }
            //   else
            //   {
            //       Console.Write("Invalid number!");
            //       return;
            //   }
            //}


            for (int i = 0; i < Input_Numbers.Length; i ++)
            {
                if (int.TryParse(Input_Numbers[i], out  numbers[i]))
                {
                    numbers.Sum();
                    numbers.Average();
                   // numbers.Reverse();
                  // sum += numbers[i];
               }
               else
                {
                    Console.Write("Invalid number!");
                    return;
                }
            }

            Console.WriteLine($"the sum of the numbers of array = {numbers.Sum()}");
            Console.WriteLine($"the average of the numbers of array = {numbers.Average()}");

            Console.Write("the reverse is: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            // Console.WriteLine($"the reverse of the numbers of array = {numbers.Reverse()}");


            Console.ReadKey();
        }
    }
}