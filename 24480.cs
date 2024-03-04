namespace BaekjoonProj
{
    internal class _24480
    {
        public static void Run(string[] args)
        {
            int[] NMR = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //1~N개 점, 0번 무시
            List<int>[] UV = new List<int>[NMR[0] + 1];
            for(int i = 0; i < NMR[0] + 1; i++)
            {
                UV[i] = new List<int>();
            }

            int[] visited = new int[NMR[0] + 1];
            for(int i = 0; i < NMR[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UV[input[0]].Add(input[1]);
                UV[input[1]].Add(input[0]);
            }
            for (int i = 0; i < NMR[0]+1;i++)
            {
                UV[i] = UV[i].OrderByDescending(x=>x).ToList();
            }
            int order = 1;
            void DFS(int cur)
            {
                visited[cur] = order;
                order++;
                foreach(int i in UV[cur])
                {
                    if (visited[i] != 0)
                    {
                        continue;
                    }
                    DFS(i);
                }
            }
            DFS(NMR[2]);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 1; i < NMR[0] + 1; i++)
            {
                sb.AppendLine(visited[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
