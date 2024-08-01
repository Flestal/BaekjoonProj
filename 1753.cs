namespace BaekjoonProj
{
    internal class _1753
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] VE = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] distances = Enumerable.Repeat(int.MaxValue, VE[0]).ToArray();
            bool[] visited = new bool[VE[0]];
            int Start = int.Parse(Console.ReadLine())-1;
            distances[Start] = 0;
            List<List<(int,int)>> list = new List<List<(int,int)>> ();//[시작점]->(도착점,가중치)리스트
            for(int i = 0; i < VE[0]; i++)
            {
                list.Add(new List<(int, int)>());
            }


            for (int ii = 0; ii < VE[1]; ii++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                input[0] -= 1; input[1] -= 1;
                list[input[0]].Add((input[1], input[2]));
            }
            PriorityQueue<(int,int),int> q = new PriorityQueue<(int, int), int> ();
            q.Enqueue((Start, distances[Start]), distances[Start]);
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
                        q.Enqueue((ii.Item1,dist),dist);
                    }
                        
                }
            }


            for(int i = 0; i < VE[0]; i++)
            {
                if (distances[i]==int.MaxValue)
                {
                    sb.AppendLine("INF");
                    continue;
                }
                sb.AppendLine(distances[i].ToString());
            }

            Console.WriteLine(sb);
        }
    }
}
