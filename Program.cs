using System.Globalization;

namespace UnderstandingScope
{
    internal class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString(j);
                Console.WriteLine(i);
            }
            //Console.WriteLine(i);
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }
}