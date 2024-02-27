using System;
using System.Collections.Generic;

namespace nettask
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        public static List<int> nums { get; set; } = new List<int>();

        public Solution() { }

        public void AddNumberToList(int num) => nums.Add(num);

        public void ClearList() => nums.Clear();

        private static long SumOfDigit(int num)
        {
            long sum = 0;
            long n = Math.Abs((long)num);
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static int ShowResult()
        {
            long maxSum = long.MinValue;
            int numberWithMaxSum = 0;

            if (nums.Count != 0)
            {
                foreach (var num in nums)
                {
                    var sum = SumOfDigit(num);
                    if (maxSum <= sum)
                    {
                        maxSum = sum;
                        numberWithMaxSum = num;
                    }
                }
            }

            Console.WriteLine($"Число с максимальной суммой цифр: {numberWithMaxSum} = {maxSum}");
            return numberWithMaxSum;
        }

    }


    class Program
    {
        public static void Main(string[] args)
        {
            Solution task = new Solution();
            for (; ; )
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number != 0)
                        task.AddNumberToList(number);
                    else
                    {
                        Solution.ShowResult();
                        task.ClearList();
                    }
                }
            }
        }    }
}
