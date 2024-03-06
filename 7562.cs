namespace BaekjoonProj
{
    internal class _7562
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] dir1 = { -1, 1, -2, 2, -1, 1, -2, 2 };
            int[] dir2 = { 2, 2, 1, 1, -2, -2, -1, -1 };
            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int _ = 0; _ < T; _++)
            {
                int I_=int.Parse(Console.ReadLine());
                int[,] board = new int[I_, I_];
                bool[,] visited = new bool[I_, I_];
                int[] CurKnight = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] target = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int d = 0;
                q.Clear();

                void BFS(int x, int y, int depth)
                {
                    if (d != 0) return;
                    if (x == target[0] && y == target[1])
                    {
                        d = depth;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        if (
                            x + dir1[i] >= 0 && x + dir1[i] < I_
                            && y + dir2[i] >= 0 && y + dir2[i] < I_
                            )
                        {
                            if (visited[x + dir1[i], y + dir2[i]]) { continue; }
                            visited[x + dir1[i], y + dir2[i]] = true;
                            q.Enqueue((x + dir1[i], y + dir2[i], depth + 1));
                        }
                    }
                    
                }
                visited[CurKnight[0], CurKnight[1]] = true;
                q.Enqueue((CurKnight[0], CurKnight[1], 0));
                while (q.Count > 0&&d==0)
                {
                    (int, int, int) item = q.Dequeue();
                    BFS(item.Item1, item.Item2, item.Item3);
                }
                sb.AppendLine(d.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
