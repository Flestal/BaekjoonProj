
namespace BaekjoonProj
{
    internal class _1912
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dp = new int[n];
            int max = N[0];
            dp[0] = N[0];
            for(int i = 1; i < n; i++)
            {
                dp[i] = Math.Max(dp[i-1] + N[i], N[i]);
                if (dp[i] > max) max = dp[i];
            }
            Console.WriteLine(max);
        }
    }
}
