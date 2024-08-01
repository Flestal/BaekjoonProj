namespace BaekjoonProj
{
    internal class _1707
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int K = int.Parse(Console.ReadLine());
            List<List<int>> UV = new List<List<int>>();
            Queue<(int,short)> q = new Queue<(int,short)>();
            short[] flags = new short[0];//0이면 기본, (-1,1)로 구분
            bool[] visited = new bool[0];
            bool endFlag=false;
            void BFS(int cur, short toggle)
            {
                if (endFlag) return;
                foreach (int item in UV[cur])
                {
                    if (visited[item])
                    {
                        if (flags[item] == toggle)
                        {
                            endFlag = true;
                        }
                        continue;
                    }
                    visited[item] = true;
                    flags[item] = (short)-toggle;
                    q.Enqueue((item, (short)-toggle));
                }
            }
            for (int _ = 0; _ < K; _++)
            {
                int[] VE = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                flags = new short[VE[0]];//점 수만큼 플래그 갱신
                visited = new bool[VE[0]];
                endFlag = false;
                UV.Clear();
                q.Clear();
                for(int i = 0; i < VE[0]; i++)
                {
                    UV.Add(new List<int>());
                }
                for(int i=0; i < VE[1]; i++)
                {
                    int[] UV_ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    UV[UV_[0] - 1].Add(UV_[1] - 1);
                    UV[UV_[1] - 1].Add(UV_[0] - 1);
                }
                for(int i = 0; i < flags.Length; i++)
                {
                    if (flags[i] == 0)
                    {
                        flags[i] = 1;
                        visited[i] = true;
                        q.Enqueue((i, 1));
                        while (q.Count > 0 && !endFlag)
                        {
                            (int, short) item = q.Dequeue();
                            BFS(item.Item1, item.Item2);
                        }
                    }
                }
                if (endFlag){ sb.AppendLine("NO"); }else { sb.AppendLine("YES"); }
            }
            Console.WriteLine(sb);
        }
    }
}
