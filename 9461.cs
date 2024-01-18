
namespace BaekjoonProj
{
    internal class _9461
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            long[] dp = new long[101];
            dp[0] = 1; dp[1] = 1; dp[2] = 1;
            dp[3] = 2; dp[4] = 2; dp[5] = 3;
            dp[6] = 4; dp[7]= 5; dp[8] = 7; dp[9]= 9;
            for(int i = 10; i <= 100; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 5];
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<T;i++)
            {
                int N=int.Parse(Console.ReadLine());
                sb.AppendLine(dp[N-1].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
