namespace BaekjoonProj
{
    internal class _7569
    {
        public static void Run(string[] args)
        {
            int[] MNH = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] dir1 = { -1, 1, 0, 0, 0, 0 };
            int[] dir2 = { 0, 0, -1, 1, 0, 0 };
            int[] dir3 = { 0, 0, 0, 0, -1, 1 };
            int[,,] board = new int[MNH[1], MNH[0],MNH[2]];
            bool[,,] visited = new bool[MNH[1], MNH[0],MNH[2]];
            Queue<(int, int, int, int)> q = new Queue<(int, int, int, int)>();
            int d = 0;
            void BFS(int x, int y, int z, int depth)
            {
                if (d < depth) d = depth;
                for (int i = 0; i < 6; i++)
                {
                    if (
                        x + dir1[i] >= 0 && x + dir1[i] < MNH[1]
                        && y + dir2[i] >= 0 && y + dir2[i] < MNH[0]
                        && z + dir3[i] >= 0 && z + dir3[i] < MNH[2]
                        )
                    {
                        if (visited[x + dir1[i], y + dir2[i], z + dir3[i]]) { continue; }
                        visited[x + dir1[i], y + dir2[i], z + dir3[i]] = true;
                        board[x + dir1[i], y + dir2[i], z + dir3[i]] = 1;
                        q.Enqueue((x + dir1[i], y + dir2[i], z + dir3[i], depth + 1));
                    }
                }
                    
            }
            for(int l = 0; l < MNH[2]; l++)
            {
                for(int i = 0; i < MNH[1]; i++)
                {
                    int[] MLine = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    for(int j=0;j< MLine.Length; j++)
                    {
                        board[i, j, l] = MLine[j];
                        if (MLine[j] == -1) { visited[i, j, l] = true; }
                        if (MLine[j] == 1)
                        {
                            visited[i, j, l] = true;
                            q.Enqueue((i, j, l, 0));
                        }
                    }
                }
            }
            while(q.Count > 0)
            {
                (int, int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3, item.Item4);
            }
            bool flag = false;
            for (int l = 0; l < MNH[2]; l++)
            {
                if (flag) break;
                for (int i = 0; i < MNH[1]; i++)
                {
                    if (flag) break;
                    for (int j = 0; j < MNH[0]; j++)
                    {
                        if (board[i, j, l] == 0)
                        {
                            d = -1;
                            flag = true;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(d);
        }
    }
}
