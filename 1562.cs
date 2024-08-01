using System.Collections.Immutable;

namespace BaekjoonProj
{
    internal class _1562
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[,,] DP = new int[10, 100, 4];
            const int MOD = 1000000000;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        DP[i, j, k] = -1;
                    }
                }
            }
            int DFS(int num, int idx, int bit)
            {
                int ret = DP[num, idx, bit];
                if (ret != -1) return ret;
                else ret = 0;
                if (idx == N-1)
                {
                    if (bit == 3)
                        return 1;
                    else return 0;
                }
                
                if (num < 9)
                {
                    ret += DFS(num + 1, idx + 1, bit | (num + 1 == 9 ? 2 : 0));
                    ret %= MOD;
                }
                if (num > 0)
                {
                    ret += DFS(num - 1, idx+1, bit | (num - 1 == 0 ? 1 : 0));
                    ret %= MOD;
                }
                DP[num, idx, bit] = ret;
                return ret;
            }

            for (int i = 1; i < 10; i++)
            {
                cnt+=DFS(i, 0, i==9?2:0);
                cnt%=MOD;
            }


            Console.WriteLine(cnt);
        }
    }
}
