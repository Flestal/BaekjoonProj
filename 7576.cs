namespace BaekjoonProj
{
    internal class _7576
    {
        public static void Run(string[] args)
        {
            int[] MN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dir1 = { -1, 1, 0, 0 };
            int[] dir2 = { 0, 0, -1, 1 };
            int[,] board = new int[MN[1], MN[0]];
            bool[,] visited = new bool[MN[1], MN[0]];
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            int d = 0;
            void BFS(int x, int y, int depth)
            {
                if (d < depth) d = depth;
                for (int i = 0; i < 4; i++)
                {
                    if (
                        x + dir1[i] >= 0 && x + dir1[i] < MN[1]
                        && y + dir2[i] >= 0 && y + dir2[i] < MN[0]
                        )
                    {
                        if (visited[x + dir1[i], y + dir2[i]]) { continue; }
                        visited[x + dir1[i], y + dir2[i]] = true;
                        board[x + dir1[i], y + dir2[i]] = 1;
                        q.Enqueue((x + dir1[i], y + dir2[i], depth + 1));
                    }
                }
                    
            }
            for(int i = 0; i < MN[1]; i++)
            {
                int[] MLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int j=0;j< MLine.Length; j++)
                {
                    board[i, j] = MLine[j];
                    if (MLine[j] == -1) { visited[i, j] = true; }
                    if (MLine[j] == 1)
                    {
                        visited[i, j] = true;
                        q.Enqueue((i, j, 0));
                    }
                }
            }
            while(q.Count > 0)
            {
                (int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3);
            }
            bool flag = false;
            for(int i=0;i < MN[1]; i++)
            {
                if (flag) break;
                for(int j = 0; j < MN[0]; j++)
                {
                    if (board[i, j] == 0)
                    {
                        d = -1;
                        flag = true;
                        break;
                    }
                }
            }
            Console.WriteLine(d);
        }
    }
}
