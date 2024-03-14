namespace BaekjoonProj
{
    internal class _1865
    {
        public static void Run(string[] args)
        {
            int TC = int.Parse(Console.ReadLine());
            
            long[] distances;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<(int, int, long)> roads;//출발,도착,시간
            long cursor, target, dist_;


            bool BellmanFord(int N, int M)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        (int, int, long) road = roads[j];
                        cursor = road.Item1;
                        target = road.Item2;
                        dist_ = road.Item3;
                        if (distances[cursor] + dist_ < distances[target])
                        {
                            distances[target] = distances[cursor] + dist_;
                            if (i == N - 1)
                            {
                                return true;
                            }
                        }
                    }
                }
                return false;
            }

            for (int _=0; _<TC; _++)
            {
                int[] NMW = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                distances = new long[NMW[0]];
                roads = new List<(int, int, long)>();
                int i = 0;
                for (; i < NMW[1]; i++)
                {
                    int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    ABC[0] -= 1; ABC[1] -= 1;
                    //roads[i] = (ABC[0], ABC[1], ABC[2]);
                    roads.Add((ABC[0], ABC[1], ABC[2]));
                    roads.Add((ABC[1], ABC[0], ABC[2]));
                }
                for (; i <NMW[1]+NMW[2]; i++)
                {
                    int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    ABC[0] -= 1; ABC[1] -= 1;
                    roads.Add((ABC[0], ABC[1], -ABC[2]));
                }
                bool res = BellmanFord(NMW[0], roads.Count);
                if (res)
                {
                    sb.AppendLine("YES");
                }
                else
                {
                    sb.AppendLine("NO");
                }
            }
            Console.Write(sb);

        }
    }
}
