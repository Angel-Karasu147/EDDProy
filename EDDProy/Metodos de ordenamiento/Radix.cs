using System;
using System.Collections.Generic;
using System.Linq;

namespace EDDemo.Metodos_de_ordenamiento
{
    internal class Radix
    {
        public static List<List<int>> RadixSort(List<int> input)
        {
            List<List<int>> passes = new List<List<int>>();
            int max = input.Max();
            int digitPlace = 1;

            while (max / digitPlace > 0)
            {
                List<int>[] buckets = new List<int>[10];
                for (int i = 0; i < buckets.Length; i++)
                {
                    buckets[i] = new List<int>();
                }

                
                foreach (var number in input)
                {
                    int bucketIndex = (number / digitPlace) % 10;
                    buckets[bucketIndex].Add(number);
                }

                
                input.Clear();
                foreach (var bucket in buckets)
                {
                    input.AddRange(bucket);
                }

               
                passes.Add(new List<int>(input));

                
                digitPlace *= 10;
            }

            return passes;
        }
    }
}
