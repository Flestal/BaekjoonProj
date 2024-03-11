namespace BaekjoonProj
{
    internal class _1504
    {
        public static void Run(string[] args)
        {
            int[] NE = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] distances = Enumerable.Repeat(int.MaxValue, NE[0]).ToArray();
            bool[] visited = new bool[NE[0]];
            int st_v1, v1_v2, v2_end, st_v2, v1_end;
            List<List<(int, int)>> list = new List<List<(int, int)>>();//[시작점]->(도착점,가중치)리스트
            for (int i = 0; i < NE[0]; i++)
            {
                list.Add(new List<(int, int)>());
            }
            for (int ii = 0; ii < NE[1]; ii++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                input[0] -= 1; input[1] -= 1;
                list[input[0]].Add((input[1], input[2]));
                list[input[1]].Add((input[0], input[2]));
            }
            int[] V = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            V[0] -= 1; V[1] -= 1;
            PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>();
            void Search(int cursor)
            {
                visited = new bool[NE[0]];
                q.Clear();
                distances = Enumerable.Repeat(int.MaxValue, NE[0]).ToArray();
                distances[cursor] = 0;
                q.Enqueue((cursor, 0), 0);
                while (q.Count > 0)
                {
                    (int, int) item = q.Dequeue();
                    if (item.Item2 > distances[item.Item1]) continue;
                    foreach ((int, int) ii in list[item.Item1])
                    {
                        int dist = item.Item2 + ii.Item2;
                        if (dist < distances[ii.Item1])
                        {
                            distances[ii.Item1] = dist;
                            q.Enqueue((ii.Item1, dist), dist);
                        }
                    }
                }
            }
            Search(V[0]);
            st_v1 = distances[0];
            v1_v2 = distances[V[1]];
            v1_end = distances[NE[0] - 1];
            Search(V[1]);
            st_v2 = distances[0];
            v2_end = distances[NE[0] - 1];
            int res = Math.Min(st_v1 + v1_v2 + v2_end, st_v2 + v1_v2 + v1_end);
            bool flag1=false, flag2=false;
            if (st_v1 == int.MaxValue || v2_end == int.MaxValue || v1_v2 == int.MaxValue)
                flag1 = true;
            if(st_v2==int.MaxValue||v1_end==int.MaxValue||v1_v2==int.MaxValue)
                flag2 = true;
            if (flag1 && flag2) res = -1;
            else if (flag1 && !flag2) res = st_v2 + v1_v2 + v1_end;
            else if (flag2 && !flag1) res = st_v1 + v1_v2 + v2_end;

            Console.WriteLine(res);
        }
    }
}
