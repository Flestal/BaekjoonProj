namespace BaekjoonProj
{
    internal class _1260
    {
        public static void Run(string[] args)
        {
            int[] NMR = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //1~N개 점, 0번 무시
            List<(int, int)>[] UV = new List<(int, int)>[NMR[0] + 1];
            for (int i = 0; i < NMR[0] + 1; i++)
            {
                UV[i] = new List<(int, int)>();
            }

            int[] visited_dfs = new int[NMR[0] + 1];
            int[] visited_bfs = new int[NMR[0] + 1];
            for (int i = 0; i < NMR[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UV[input[0]].Add((input[1], 1));
                UV[input[1]].Add((input[0], 1));
            }
            for (int i = 0; i < NMR[0] + 1; i++)
            {
                UV[i] = UV[i].OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToList();
            }
            int order_bfs = 1, order_dfs = 1;
            System.Text.StringBuilder sb1 = new System.Text.StringBuilder(), sb2 = new System.Text.StringBuilder();
            Queue<int> q = new Queue<int>();
            void BFS(int cur)
            {
                foreach ((int, int) i in UV[cur])
                {
                    if (visited_bfs[i.Item1] != 0)
                    {
                        continue;
                    }
                    visited_bfs[i.Item1] = order_bfs++;
                    sb2.Append(i.Item1.ToString() + " ");
                    q.Enqueue(i.Item1);
                }
            }
            void DFS(int cur)
            {
                sb1.Append(cur.ToString() + " ");
                visited_dfs[cur] = order_dfs++;
                foreach((int,int) i in UV[cur])
                {
                    if (visited_dfs[i.Item1] != 0) {  continue; }
                    DFS(i.Item1);
                }
            }
            visited_bfs[NMR[2]] = order_bfs++;
            sb2.Append(NMR[2].ToString() + " ");
            q.Enqueue(NMR[2]);
            while (q.Count > 0)
            {
                BFS(q.Dequeue());
            }
            DFS(NMR[2]);
            
            sb1.Remove(sb1.Length - 1, 1);
            sb2.Remove(sb2.Length - 1, 1);
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);
        }
    }
}
