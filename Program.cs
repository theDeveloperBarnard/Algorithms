using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            sorting sortClass = new sorting();
            int[] test = {2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5,2,3,1,5};
            sortClass.mergeSort(test, 0, test.Length - 1);
            Console.WriteLine(string.Join(",",test));

        }
    }
}
