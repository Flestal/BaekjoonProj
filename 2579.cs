
namespace BaekjoonProj
{
    internal class _2579
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] T = new int[n+1];
            int[] dp = new int[n+1];
            for(int i = 1; i < n+1; i++)
            {
                int S=int.Parse(Console.ReadLine());
                T[i] = S;
            }
            if (n == 1)
            {
                Console.WriteLine(T[1]);
                return;
            }
            if (n == 2)
            {
                Console.WriteLine(T[1] + T[2]);//dp[0], T[0]은 0임
                return;
            }
            dp[1] = T[1]; dp[2] = T[1] +T[2];
            for(int i=3; i < n+1; i++)
            {
                dp[i]= Math.Max(dp[i - 3] + T[i - 1] + T[i], dp[i - 2] + T[i]);
            }
            Console.WriteLine(dp[n]);
        }
    }
}
