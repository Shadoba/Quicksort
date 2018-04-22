using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 3, 1, 5, 4, 12, 3, 5, 7, 8, 0 , 2, 4, 0, 0, 3};
            Console.WriteLine("Hello World!");
            for( int i = 0; i < test.Length; i++)
            Console.Write("{0}, ", test[i]);
            Quicksort.quicksort<int>(ref test, (int x, int y) => { return x < y; }, Partition.Lomuto, 0, test.Length - 1);
            Console.WriteLine("\n");
            for (int i = 0; i < test.Length; i++)
                Console.Write("{0}, ", test[i]);
            Quicksort.quicksort<int>(ref test, (int x, int y) => { return x < y; }, Partition.Hoare, 0, test.Length - 1);
            Console.WriteLine("\n");
            for (int i = 0; i < test.Length; i++)
                Console.Write("{0}, ", test[i]);
            Console.ReadKey();

        }
    }
}
