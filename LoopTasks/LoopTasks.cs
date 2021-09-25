using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int[] result = n.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int sum = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] % 2 != 0)
                    sum += result[i];
            }
            return sum;
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                count++;
            }
            return count;   
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 0;
            int f1, f2, f3, i = 2, sum = 1;
            f1 = 0;
            f2 = 1;
            while (i < n)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
                sum = sum + f3;
                i++;
            }
            return sum;
        }
    }
}
