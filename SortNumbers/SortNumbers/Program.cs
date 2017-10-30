using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of values want to enters");
            int NumberValues = int.Parse(Console.ReadLine());
            int[] Numbers = new int[NumberValues];

            for (int i = 0; i < NumberValues; i++)
            {
                Console.WriteLine(string.Format("Enter the value: {0}, please", i + 1));
                Numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Numbers);
            Console.WriteLine("The values are: " + string.Join(",", Numbers));
            Console.ReadKey();
        }
    }
}
