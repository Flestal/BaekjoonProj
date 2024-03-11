namespace BaekjoonProj
{
    internal class _2206
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] board = new int[NM[0], NM[1]];
            int[,,] visited = new int[NM[0], NM[1],2];
            for (int i = 0; i < NM[0]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => (int)char.GetNumericValue(c));
                for (int j = 0; j < input.Length; j++)
                {
                    board[i, j] = input[j];
                }
            }
            int[] dir1 = { 0, 0, -1, 1 };
            int[] dir2 = { -1, 1, 0, 0 };
            Queue<(int,int,int,int)> q = new Queue<(int,int,int,int)>();//(현재칸, 벽 부쉈는지, 반복깊이)
            void BFS(int x,int y, int broke,int depth)
            {
                
                if (x == NM[0]-1 && y == NM[1]-1)
                {
                    return;
                }
                for(int i=0;i<4;i++)
                {
                    int b = broke;
                    if (x + dir1[i] < 0 || x + dir1[i] >= NM[0] || y + dir2[i] < 0 || y + dir2[i] >= NM[1]) continue;
                    if (visited[x + dir1[i], y + dir2[i],b] != 0) continue;
                    if (board[x + dir1[i], y + dir2[i]]==1)
                    {
                        if (broke == 0)
                        {
                            b = 1;
                        }
                        else { continue; }
                    }
                    visited[x + dir1[i], y + dir2[i], b] = depth;
                    q.Enqueue((x + dir1[i], y + dir2[i], b, depth + 1));
                }
            }
            visited[0,0,0] = 1;
            board[0, 0] = -1;
            q.Enqueue((0, 0, 0, 2));
            while (q.Count > 0)
            {
                (int, int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3, item.Item4);
            }

            //for (int i = 0; i < NM[0]; i++)
            //{
            //    for (int j = 0; j < NM[1]; j++)
            //    {
            //        Console.Write(visited[i, j, 0] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < NM[0]; i++)
            //{
            //    for (int j = 0; j < NM[1]; j++)
            //    {
            //        Console.Write(visited[i, j, 1] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int res = visited[NM[0] - 1, NM[1] - 1, 0];
            if (res == 0 || (res != 0 && res > visited[NM[0] - 1, NM[1] - 1, 1]&& visited[NM[0] - 1, NM[1] - 1, 1]!=0))
            {
                res = visited[NM[0] - 1, NM[1] - 1, 1];
            }
            if (res == 0) res = -1;
            Console.WriteLine(res);
        }
    }
}
