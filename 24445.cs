namespace BaekjoonProj
{
    internal class _24445
    {
        public static void Run(string[] args)
        {
            int[] NMR = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //1~N개 점, 0번 무시
            List<(int,int)>[] UV = new List<(int, int)>[NMR[0] + 1];
            for(int i = 0; i < NMR[0] + 1; i++)
            {
                UV[i] = new List<(int, int)>();
            }

            int[] visited = new int[NMR[0] + 1];
            for(int i = 0; i < NMR[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UV[input[0]].Add((input[1],1));
                UV[input[1]].Add((input[0],1));
            }
            for (int i = 0; i < NMR[0]+1;i++)
            {
                UV[i] = UV[i].OrderBy(x=>x.Item2).ThenByDescending(x=>x.Item1).ToList();
            }
            int order = 1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Queue<int> q = new Queue<int>();
            void BFS(int cur)
            {
                foreach((int,int) i in UV[cur])
                {
                    if (visited[i.Item1] != 0)
                    {
                        continue;
                    }
                    visited[i.Item1] = order++;
                    q.Enqueue(i.Item1);
                }
            }
            visited[NMR[2]] = order++;
            q.Enqueue(NMR[2]);
            while (q.Count > 0)
            {
                BFS(q.Dequeue());
            }
            
            for(int i = 1; i < NMR[0] + 1; i++)
            {
                sb.AppendLine(visited[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
