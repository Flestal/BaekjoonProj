
namespace BaekjoonProj
{
    internal class _1932
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] T = new int[n + 1, n];
            for(int i = 0; i < n; i++)
            {
                T[0, i] = -1;
            }
            int[,] dp = new int[n + 1, n];
            for (int i = 1; i < n + 1; i++)
            {
                int[] ii = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0; j < ii.Length; j++)
                {
                    T[i,j] = ii[j];
                }
                for(int j=ii.Length; j < n; j++)
                {
                    T[i, j] = -1;
                }
            }
            for(int i = 1; i < n + 1; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + T[i,0];
                for(int j = 1; j < n; j++)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j] + T[i,j], dp[i - 1, j-1] + T[i,j]);
                }
            }
            int res = -1;
            for(int i=0;i < n; i++)
            {
                if (dp[n, i] > res) res = dp[n,i];
            }
            Console.WriteLine(res);
        }
    }
}
