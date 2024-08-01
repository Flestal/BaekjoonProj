namespace BaekjoonProj
{
    internal class _12852
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] visited = new int[N+1];
            Queue<(int, int)> q = new Queue<(int,int)>();
            int resDepth=-1;
            void BFS(int cur, int depth)
            {
                if (cur % 3 == 0)
                {
                    if (cur / 3 == 1)
                    {
                        visited[1] = cur;
                        resDepth = depth;
                        q.Clear();
                        return;
                    }
                    if (visited[cur / 3]==0)
                    {
                        visited[cur / 3] = cur;
                        q.Enqueue((cur / 3, depth+1));
                    }
                }
                if (cur % 2 == 0)
                {
                    if (cur / 2 == 1)
                    {
                        visited[1] = cur;
                        resDepth = depth;
                        q.Clear();
                        return;
                    }
                    if (visited[cur / 2] == 0)
                    {
                        visited[cur / 2] = cur;
                        q.Enqueue((cur / 2, depth+1));
                    }
                }
                if (cur - 1 >= 0)
                {
                    if (cur - 1 == 1)
                    {
                        visited[1] = cur;
                        resDepth = depth;
                        q.Clear();
                        return;
                    }
                    if (visited[cur - 1] == 0)
                    {
                        visited[cur - 1] = cur;
                        q.Enqueue((cur-1,depth+1));
                    }
                }
            }
            visited[N] = -1;
            q.Enqueue((N,0));
            while (q.Count > 0)
            {
                (int, int) item = q.Dequeue();
                BFS(item.Item1,item.Item2);
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int check = 1;
            Stack<int> resStack = new Stack<int>();
            while (check != -1 && visited[check]!=-1)
            {
                resStack.Push(visited[check]);
                check = visited[check];
            }
            while(resStack.Count > 0)
            {
                sb.Append(resStack.Pop()).Append(' ');
            }
            sb.Append('1');
            Console.WriteLine(resDepth+1);
            Console.WriteLine(sb);
        }
    }
}
