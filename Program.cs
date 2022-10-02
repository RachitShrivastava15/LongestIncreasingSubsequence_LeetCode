namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10,9,2,5,3,7,101,18};
            int result = LongestIncreasingSubsequence(nums);
            Console.WriteLine(result);
        }

        static int LongestIncreasingSubsequence(int[] nums)
        {
            var dp = new int[nums.Length];
            Array.Fill(dp, 1);
            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], 1 + dp[j]);
                    }
                }
            }

            return dp.Max();
        }
    }
}