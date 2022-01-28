using System;

namespace AArvvaniAlgorithms.Search
{
    public static class BinarySearch
    {
        public static int? Search(int[] numbers , int target) {

            int first = 0;
            int last = numbers.Length - 1;

            while ( first <= last)
            {
                int midpoint = (int)Math.Round((decimal)(first + last) / 2);

                if (numbers[midpoint] == target)
                {
                    return midpoint;
                }
                else if (numbers[midpoint] < target)
                {
                    first = midpoint + 1;
                }
                else {
                    last = midpoint - 1;
                }
            }
            return null;
        }

        public static int? BinarySearch2(this int[] array, int key)
        {
            return array.Search(key, 0, array.Length - 1);
        }

        private static int? Search(this int[] array, int key, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            int midIndex = (leftIndex + rightIndex) / 2;

            if (array[midIndex] == key)
            {
                return array[midIndex];
            }

            if (array[midIndex] > key)
            {
                return array.Search(key, leftIndex, midIndex - 1);
            }

            return array.Search(key, midIndex + 1, rightIndex);
        }

    }
}
