namespace BaekjoonProj
{
    internal class _2618
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            int[,] DP = new int[T + 2, T + 2];//[0]:1찰차,[1]:2찰차
            int[,] Track = new int[T + 2, T + 2];
            int[,] graph = new int[T + 2, T + 2];
            (int, int)[] TPos = new (int, int)[T + 2];
            for(int i=0;i<T+2; i++)
            {
                for (int j = 0; j < T+2; j++)
                {
                    DP[i, j] = -1;
                }
            }
            void DFS(int p1,int p2)
            {
                int Next = Math.Max(p1, p2) + 1;
                if (Next == T + 2) return;
                if (DP[Next, p2] == -1) DFS(Next, p2);
                if (DP[p1, Next] == -1) DFS(p1, Next);
                int x1 = DP[Next, p2] + graph[p1, Next];
                int x2 = DP[p1, Next] + graph[p2, Next];
                if (x1 < x2)
                {
                    DP[p1, p2] = x1; Track[p1, p2] = 1;
                }
                else
                {
                    DP[p1, p2] = x2; Track[p1, p2] = 2;
                }
            }
            TPos[0] = (0, 0);
            TPos[1] = (N-1, N-1);
            for(int l=0;l<T; l++)
            {
                int[] pos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pos[0]--; pos[1]--;
                TPos[l+2] = (pos[0], pos[1]);
            }
            for(int i = 0; i < T + 1; i++)
            {
                for(int j=i+1; j < T+2; j++)
                {
                    graph[i, j] = 
                        Math.Abs(TPos[i].Item1 - TPos[j].Item1)
                        + Math.Abs(TPos[i].Item2 - TPos[j].Item2);
                }
            }
            DFS(0, 1);
            sb.AppendLine((DP[0,1]+1).ToString());
            int p1 = 0, p2 = 1;
            while (Math.Max(p1, p2) < T + 1)
            {
                sb.AppendLine(Track[p1, p2].ToString());
                if (Track[p1, p2] == 1) p1 = Math.Max(p1, p2) + 1;
                else p2 = Math.Max(p1, p2) + 1;
            }
            Console.Write(sb);
        }
    }
}
