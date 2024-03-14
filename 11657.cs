namespace BaekjoonProj
{
    internal class _11657
    {
        public static void Run(string[] args)
        {
            const long MAX = int.MaxValue;
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] distances = Enumerable.Repeat(MAX, NM[0]).ToArray();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            (int, int, long)[] roads = new (int, int, long)[NM[1]];//출발,도착,시간
            long cursor, target, dist_;
            for(int i = 0; i < NM[1]; i++)
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ABC[0] -= 1; ABC[1] -= 1;
                //roads[ABC[0]].Add((ABC[1], ABC[2]));
                roads[i] = (ABC[0], ABC[1], ABC[2]);
            }

            bool BellmanFord(int start)
            {
                distances[start] = 0;
                for(int i = 0; i < NM[0]; i++)
                {
                    for (int j = 0; j < NM[1]; j++)
                    {
                        (int, int, long) road = roads[j];
                        cursor = road.Item1;
                        target = road.Item2;
                        dist_ = road.Item3;
                        if (distances[cursor] != MAX && distances[cursor] + dist_ < distances[target])
                        {
                            distances[target] = distances[cursor]+dist_;
                            if (i == NM[0] - 1)
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            bool res = BellmanFord(0);
            if (!res)
            {
                Console.WriteLine(-1);
                return;
            }
            for(int i=1;i< NM[0]; i++)
            {
                if (distances[i] == MAX) distances[i] = -1;
                sb.AppendLine(distances[i].ToString());
            }
            Console.Write(sb);

        }
    }
}
