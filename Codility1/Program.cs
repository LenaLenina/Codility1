using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//26 минут

namespace Codility1
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int result = solution.solution(1041);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            string convertData = ConverData(N);
            List<int> results = GetGap(convertData);
            return results.Max();
        }

        private static List<int> GetGap(string convertData)
        {
            List<int> results = new List<int>();

            int result = 0;

            foreach (var item in convertData)
            {
                if (item == '0')
                {
                    result++;
                }
                else
                {
                    results.Add(result);
                    result = 0;
                }
            }

            return results;
        }

        private string ConverData(int N)
        {
            return Convert.ToString(N, 2);
        }
    }
}
