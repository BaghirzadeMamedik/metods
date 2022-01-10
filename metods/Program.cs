using System;

namespace Initial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Mamedik";

            //test.GetHashCode();
            Console.WriteLine(test.GetTypeCode());
            Console.WriteLine(test.GetHashCode());

            int[] Num = { 10, 20, 30, 40 };

            Console.WriteLine(Num.Max());
            Console.WriteLine(Num.Min());
        }
    }
}
