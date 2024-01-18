
namespace BaekjoonProj
{
    internal class _1904
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            short[] dp = new short[N+1];
            dp[0] = 1; dp[1] = 1;
            for(int i = 2; i <= N; i++)
            {
                dp[i] = (short)((dp[i - 1] + dp[i - 2])%15746);
            }
            Console.WriteLine(dp[N]);
        }
    }
}
