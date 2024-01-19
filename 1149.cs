
namespace BaekjoonProj
{
    internal class _1149
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] RGB = new int[n + 1, 3];
            int[,] dp = new int[n + 1, 3];
            for (int i = 1; i < n + 1; i++)
            {
                int[] ii = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                RGB[i, 0] = ii[0];
                RGB[i, 1] = ii[1];
                RGB[i, 2] = ii[2];
            }
            for (int i = 1; i < n + 1; i++)
            {
                dp[i, 0] = Math.Min(dp[i - 1, 1], dp[i - 1, 2]) + RGB[i, 0];
                dp[i, 1] = Math.Min(dp[i - 1, 0], dp[i - 1, 2]) + RGB[i, 1];
                dp[i, 2] = Math.Min(dp[i - 1, 0], dp[i - 1, 1]) + RGB[i, 2];
            }
            int res = dp[n, 0];
            if (dp[n, 1] < res) { res = dp[n, 1]; }
            if (dp[n, 2] < res) { res = dp[n, 2]; }
            Console.WriteLine(res);
        }
    }
}
