namespace BaekjoonProj
{
    internal class _17484
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] board = new int[NM[0], NM[1]];
            int[,] DP = new int[NM[0], NM[1]];
            int Min = int.MaxValue;
            Queue<(int, int, int, int)> q = new Queue<(int, int, int, int)>();
            for(int i = 0; i < NM[0]; i++)
            {
                int[] NLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0;j < NM[1]; j++)
                {
                    board[i, j] = NLine[j];
                }
            }
            void BFS(int n,int m,int lastDir,int sum)
            {
                if (n == -1)
                {
                    for(int i = 0; i < NM[1]; i++)
                    {
                        q.Enqueue((0, i, -10, board[0,i]));
                    }
                    return;
                }
                if (n == NM[0] - 1)
                {
                    Min=Math.Min(Min, sum);
                    return;
                }

                if (lastDir != -1 && m > 0)
                    q.Enqueue((n + 1, m - 1, -1, sum + board[n+1, m-1]));
                if (lastDir != 0)
                    q.Enqueue((n+1,m,0, sum + board[n+1, m]));
                if (lastDir != 1 && m < NM[1]-1)
                    q.Enqueue((n+1,m+1,1, sum + board[n+1, m+1]));


            }
            q.Enqueue((-1, 0, 0, 0));
            while (q.Count > 0)
            {
                (int, int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3, item.Item4);
            }

            Console.WriteLine(Min);
        }
    }
}
