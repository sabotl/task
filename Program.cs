    using System;

    public class Solution { 
        private static List<int> nums {  get; set; } = new List<int>();
        public Solution() { }
        public void AddNumberToList(int num) => nums.Add(num);
        public void ClearList() => nums.Clear();
        private static int SumOfDigit(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                if (num != 0)
                    sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        public static void ShowResult()
        {
            int maxSum = int.MinValue;
            int numberWithMaxSum = 0;

            if(nums.Count != 0)
                foreach (var num in nums)
                {
                    var sum = SumOfDigit(num);
                    if(maxSum < sum)
                    {
                        maxSum = sum;
                        numberWithMaxSum = num;
                    }
                }
            Console.WriteLine($"Число с максимальной суммой цифр: {numberWithMaxSum} = {maxSum}");
        }
    }

class Program
{
    public static void Main(string[] args)
    {
        Solution task = new();
       for(; ;)
       {
            if(int.TryParse(Console.ReadLine(), out int number))
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
    }
}
