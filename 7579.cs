namespace BaekjoonProj
{
    internal class _7579
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int[]> list = new List<int[]>();
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum_m = 0;
            foreach(int mm in m)
            {
                sum_m += mm;
            }
            for (int i = 0; i < NM[0]; i++)
            {
                list.Add(new int[] { A[i], m[i] });
            }
            int[][] DP = new int[list.Count + 1][];
            for (int i = 0; i < list.Count+1; i++)
            {
                DP[i]=new int[sum_m + 1];
            }

            for(int i=0;i<DP.Length;i++)//세로 진행
            {
                //int[] item = list[i];
                for(int j = 0; j < DP[0].Length; j++)//가로 진행(메모리 비용)
                {
                    if (i == 0) DP[i][j] = 0;
                    else if (list[i-1][1]<=j)//이번 아이템의 용량이 빼기가 가능하면
                    {
                        DP[i][j] = 
                            Math.Max(
                                DP[i - 1][j - list[i - 1][1]] + list[i - 1][0]//같은줄 0 더하는 것 아닌 윗줄 0 더하는 것
                                , DP[i][j]);
                        DP[i][j] = Math.Max(DP[i][j], DP[i - 1][j]);
                    }
                    else
                    {
                        DP[i][j] = DP[i - 1][j];
                    }
                }
            }
            int res = int.MaxValue;
            for(int i = 0; i < DP.Length; i++)
            {
                for(int j=0;j < DP[0].Length; j++)
                {
                    if (DP[i][j] >= NM[1]&&j<res)
                    {
                        res = j;
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
