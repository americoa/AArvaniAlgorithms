using System;
using System.Collections.Generic;
using System.Linq;

namespace AArvaniAlgorithms.Others
{
    public class SequencialDigits
    {
        /*
         An integer has sequential digits if and only if each digit in the number is one more than the previous digit. 
        Return a sorted list of all the integers in the range [low, high] inclusive that have sequential digits.

        Example 1:
        Input: low = 100, high = 300
        Output: [123,234]

        Example 2:
        Input: low = 1000, high = 13000
        Output: [1234,2345,3456,4567,5678,6789,12345]

        Constraints:
        10 <= low <= high <= 10^9
        */



        public static List<int> BruteForce(int low, int hight)
        {

            List<int> allOptions = new List<int>()
            {
                12,23,34,56,78,89,
                123,234,345,456,567,678,789,
                1234,2345,3456,4567,5678,6789,
                12345,23456,34567,45678,56789,
                123456,234567,345678,456789,
                1234567,2345678,3456789,
                12345678,23456789,
                123456789
            };
            List<int> response = new List<int>();
            foreach (var item in allOptions)
            {
                if (item >= low && item <= hight)
                {
                    response.Add(item);
                }
                else if (item > hight)
                {
                    break;
                }
            }
            return response;
        }


        public static List<int> BruteForceDynamic(int low, int hight)
        {

            List<int> response = new List<int>();
            for (int i = 1; i < 10; ++i)
            {
                int value = 0;
                for (int j = i; j < 10; ++j)
                {
                    value = value * 10 + j;
                    if ((value <= hight) && (value >= low))
                    {
                        response.Add(value);
                    }
                }
            }
            response = response.OrderBy(p => p).ToList();
            return response;
        }

        public static List<int> DepthFirstSearch(int low, int hight)
        {

            List<int> response = new List<int>();

            for (int i = 1; i <= 9; ++i)
            {
                List<int> v = dfs(low, hight, i);
                if (v.Any())
                {
                    response.AddRange(v);
                }
            }
            
            response = response.OrderBy(p => p).ToList();

            return response;
        }

        private static List<int> dfs(int low, int high, int cur = 0)
        {
            List<int> res = new List<int>();
            if (cur >= low && cur <= high)
            {
                res.Add(cur);
            }
            
            if (cur >= high)
            {
                return res;
            }
            int x = cur % 10;
            if (x != 9)
            {
                List<int> v = dfs(low, high, cur * 10 + x + 1);
                if (v.Any())
                {
                    //res.insert(res.end(), begin(v), end(v));
                    res.AddRange(v);
                }
            }
            
            return res;
        }

    }
}
