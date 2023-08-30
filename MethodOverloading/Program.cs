using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal decimal1, decimal decimal2)
        {
            return decimal1 + decimal2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";
            if (isTrue)
            {
                sum = num1 + num2;

                if (sum == 1)
                {
                    response = $"{sum} dollar";
                }
                else response = $"{sum} dollars";
            }
            return response;
        }
        static void Main(string[] args)
        {
            Add(2, 3);
            Console.WriteLine(Add(2,3));
            Add(33.3m, 44.4m);
            Console.WriteLine(Add(33.3m, 44.4m));
            Add(5, 6, true);
            Console.WriteLine(Add(5, 6, true));

          
           


        }
    }
}
