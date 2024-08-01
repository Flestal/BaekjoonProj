namespace BaekjoonProj
{
    internal class _9370
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] distances;
            bool[] visited;
            List<List<(int, int)>> list;
            int[] EndPoints;
            int[] st_end,g_end,h_end;
            int dist_;
            PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>();
            void Init(int N)
            {
                distances = Enumerable.Repeat(int.MaxValue, N).ToArray();
                visited= new bool[N];
            }
            void Search(int start)
            {
                q.Clear();
                distances[start] = 0;
                q.Enqueue((start, 0), 0);
                while (q.Count > 0)
                {
                    (int, int) item = q.Dequeue();
                    if (item.Item2 > distances[item.Item1]) continue;
                    dist_ = item.Item2 + 1;
                    foreach((int,int) ii in list[item.Item1])
                    {
                        dist_ = item.Item2 + ii.Item2;
                        if (dist_ < distances[ii.Item1])
                        {
                            distances[ii.Item1] = dist_;
                            q.Enqueue((ii.Item1, dist_), dist_);
                        }
                    }
                }
            }
            for(int _=0; _<T; ++_)
            {
                int[] NMT = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] SGH = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                SGH[0] -= 1; SGH[1] -= 1; SGH[2] -= 1;
                list = new List<List<(int,int)>>();
                for(int i = 0; i < NMT[0]; i++)
                {
                    list.Add(new List<(int, int)>());
                }
                EndPoints = new int[NMT[2]];
                st_end = new int[NMT[2]];
                g_end = new int[NMT[2]];
                h_end = new int[NMT[2]];
                for (int i = 0; i < NMT[1]; i++)
                {
                    int[] ABD = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    ABD[0] -= 1; ABD[1]-=1;
                    list[ABD[0]].Add((ABD[1], ABD[2]));
                    list[ABD[1]].Add((ABD[0], ABD[2]));
                }
                for(int i = 0; i < NMT[2]; i++)
                {
                    int x = int.Parse(Console.ReadLine());
                    EndPoints[i] = x-1;
                }
                EndPoints=EndPoints.OrderBy(x => x).ToArray();

                int st_g, st_h,g_h;
                Init(NMT[0]);
                Search(SGH[0]);//시작점 -> 끝점들 최단거리
                st_g = distances[SGH[1]];
                st_h = distances[SGH[2]];
                for(int i = 0; i < NMT[2]; i++)
                {
                    st_end[i] = distances[EndPoints[i]];
                }//이거때문에 이번엔 서치를 시작점에서 한번은 해야됨
                Init(NMT[0]);
                Search(SGH[1]);//G지점-> 끝점들 최단거리
                g_h = distances[SGH[2]];
                for (int i = 0; i < NMT[2]; i++)
                {
                    g_end[i] = distances[EndPoints[i]];
                }
                Init(NMT[0]);
                Search(SGH[2]);//H지점-> 끝점들 최단거리
                for (int i = 0; i < NMT[2]; i++)
                {
                    h_end[i] = distances[EndPoints[i]];
                }
                //서치 완료, 최단거리 계산
                for(int i = 0; i < NMT[2]; i++)
                {
                    if (st_end[i] == st_h+g_h+g_end[i] 
                        || st_end[i] == st_g+g_h+h_end[i]
                        )
                    {
                        sb.Append(EndPoints[i]+1).Append(' ');
                    }
                }
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();

            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
