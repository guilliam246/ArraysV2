using System;

namespace ArraysV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  numbers = new [] { 3, 7, 2, 9, 12, 69 };

            //lenght
            Console.WriteLine("Length:" + numbers.Length);

            //indexOf()

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:" + index);

            //Clear Method

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            //copy()

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
        }
    }
}
