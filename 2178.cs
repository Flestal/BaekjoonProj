namespace BaekjoonProj
{
    internal class _2178
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] board = new int[NM[0], NM[1]];
            bool[,] visited = new bool[NM[0], NM[1]];
            for(int i = 0; i < NM[0]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c=>(int)char.GetNumericValue(c));
                for(int j=0; j < NM[1]; j++)
                {
                    board[i, j] = input[j];
                    if (input[j]==0) visited[i,j] = true;
                    else visited[i,j] = false;
                }
            }
            int cnt = 0;
            int[] dir1 = { -1, 1, 0, 0 };
            int[] dir2 = { 0, 0, -1, 1 };
            Queue<(int,int,int)> q = new Queue<(int,int,int)>();
            int d = int.MaxValue;
            void BFS(int x,int y,int depth)
            {
                for(int i = 0; i < 4; i++)
                {
                    if (
                        x + dir1[i] >= 0 && x + dir1[i] < NM[0]
                        && y + dir2[i] >= 0 && y + dir2[i] < NM[1]
                        )
                    {
                        if (visited[x + dir1[i], y + dir2[i]]) { continue; }
                        visited[x + dir1[i], y + dir2[i]] = true;
                        cnt++;
                        q.Enqueue((x + dir1[i], y + dir2[i],depth+1));
                    }
                }
                if (x == NM[0] - 1 && y == NM[1]-1)
                {
                    if (depth < d) d = depth;
                }
            }
            visited[0,0] = true;
            q.Enqueue((0,0,1));
            while (q.Count > 0)
            {
                (int,int,int) item= q.Dequeue();
                BFS(item.Item1,item.Item2,item.Item3);
            }
            Console.WriteLine(d);
        }
    }
}
