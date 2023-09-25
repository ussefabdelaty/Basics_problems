using System.Transactions;

namespace switch_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Case of SWITCH
            /*
            Console.WriteLine("enter the amount of currency that you want to convert!");
           // int Amount_currnecy;
            int.TryParse(Console.ReadLine(),out int Amount_currency);
            Console.WriteLine("enter which currency you want to convert (usd - eur - cad)");
            string currType = Console.ReadLine();

            var JODTOUSD = 1.44d;
            var JODTOEUR = 1.77d;
            var JODTOCAD = 1.88d;

            switch (currType)
            {
                case "usd":
                    double output = JODTOUSD * Amount_currency;
                    Console.WriteLine($"{Amount_currency}JOD = {output}USD");
                    break;
                case "eur":
                    output = JODTOEUR * Amount_currency;
                    Console.WriteLine($"{Amount_currency}JOD = {output}EUR");
                    break;
                case "cad":
                    output = JODTOCAD * Amount_currency;
                    Console.WriteLine($"{Amount_currency}JOD = {output}CAD");
                    break;
                default:
                    Console.WriteLine($"non-valid");
                    break;
            }
            */
            int num = 3;
            switch (num)
            {
                case 1:
                case 3:
                case 5:
                case 9:
                    Console.WriteLine("odd");
                    break;
                case 0: 
                case 2: case 4:
                case 6: 
                case 8:
                    Console.WriteLine("even");
                    break;  
            }
            Console.ReadKey()
;              
        }
    }
}