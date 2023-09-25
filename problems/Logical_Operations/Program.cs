namespace Logical_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;

            bool LogicalAnd = A && B;

            bool LogicalOr = A || B;

            bool ResultNot = !A;

            Console.WriteLine(" A and B =" + " " + LogicalAnd);
            Console.WriteLine(" A or B  =" +  " " +LogicalOr);
            Console.WriteLine(" Not A   =" + " " + ResultNot);
            Console.ReadKey();
        }
    }
}