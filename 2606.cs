namespace BaekjoonProj
{
    internal class _2606
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            //1~N개 점, 0번 무시
            List<(int,int)>[] UV = new List<(int, int)>[N + 1];
            for(int i = 0; i < N + 1; i++)
            {
                UV[i] = new List<(int, int)>();
            }

            bool[] visited = new bool[N + 1];
            for(int i = 0; i < M; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UV[input[0]].Add((input[1],1));
                UV[input[1]].Add((input[0],1));
            }
            for (int i = 0; i < N+1;i++)
            {
                UV[i] = UV[i].OrderBy(x=>x.Item2).ThenByDescending(x=>x.Item1).ToList();
            }
            int cnt = 0;
            Queue<int> q = new Queue<int>();
            void BFS(int cur)
            {
                foreach((int,int) i in UV[cur])
                {
                    if (visited[i.Item1])
                    {
                        continue;
                    }
                    visited[i.Item1] = true;
                    cnt++;
                    q.Enqueue(i.Item1);
                }
            }
            visited[1] = true;
            q.Enqueue(1);
            while (q.Count > 0)
            {
                BFS(q.Dequeue());
            }
            Console.WriteLine(cnt);
        }
    }
}
