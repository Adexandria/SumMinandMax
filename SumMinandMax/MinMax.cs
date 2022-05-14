using System;

namespace SumMinandMax
{
    class MinMax
    {
        static void Main(string[] args)
        {
            int[] s = { 9,3,2,4,7,10,16 };
            
            Console.WriteLine("Iterative process of min number:");
            int min = Min(s, s.Length);

            Console.WriteLine("Iterative process of max number:");
            int max = Max(s, s.Length);

            Console.WriteLine($"The total sum of the largest number {max} and the smallest number {min} is {min + max}");
        }

        // This function gets the minimum number in the array
        public static int Min(int[] array, int length)
        {
            // if the array length is 1, it will return the first index of the array
            if(length == 1)
            {
                return array[0];
            }
            int min = Math.Min(array[length - 1], Min(array, (length - 1)));

            //print out the min number 
            Console.WriteLine(min);
            return min;
        }

        // This function gets the maximum number in the array
        public static int Max(int[] array,int length)
        {
            // if the array length is 1, it will return the first index of the array
            if ( length == 1)
            {
                return array[0];
            }
            int max = Math.Max(array[length - 1],Max(array, (length - 1)));

            //print out the max number
            Console.WriteLine(max);

            return max;
        }
    }
}
