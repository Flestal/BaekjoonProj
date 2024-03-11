namespace BaekjoonProj
{
    internal class _14923
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] Start = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] End = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for(int i = 0; i < 2; i++)
            {
                Start[i] -= 1; End[i]-=1;
            }
            int[,] board = new int[NM[0], NM[1]];
            int[,,] visited = new int[NM[0], NM[1],2];
            for (int i = 0; i < NM[0]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
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
            visited[Start[0], Start[1],0] = 1;
            board[Start[0], Start[1]] = -1;
            q.Enqueue((Start[0], Start[1], 0, 1));
            while (q.Count > 0)
            {
                (int, int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3, item.Item4);
            }

            //for (int i = 0; i < nm[0]; i++)
            //{
            //    for (int j = 0; j < nm[1]; j++)
            //    {
            //        console.write(visited[i, j, 0] + " ");
            //    }
            //    console.writeline();
            //}
            //console.writeline();
            //for (int i = 0; i < nm[0]; i++)
            //{
            //    for (int j = 0; j < nm[1]; j++)
            //    {
            //        console.write(visited[i, j, 1] + " ");
            //    }
            //    console.writeline();
            //}

            int res = visited[End[0], End[1], 0];
            if (res == 0 || (res != 0 && res > visited[End[0], End[1], 1]&& visited[End[0], End[1], 1]!=0))
            {
                res = visited[End[0], End[1], 1];
            }
            if (res == 0) res = -1;
            Console.WriteLine(res);
        }
    }
}
