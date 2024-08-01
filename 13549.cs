namespace BaekjoonProj
{
    internal class _13549
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            //int[] Points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] distances;// = new int[100001];
            bool[] visited;// = new bool[100001];
            PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>();

            int dist;
            void Search(int cursor)
            {
                visited = new bool[100001];
                q.Clear();
                //distances = new int[100001];
                distances = Enumerable.Repeat(int.MaxValue, 100001).ToArray();
                distances[cursor] = 0;
                q.Enqueue((cursor, 0), 0);
                while (q.Count > 0)
                {
                    (int, int) item = q.Dequeue();
                    if (item.Item2 > distances[item.Item1]) continue;
                    dist = item.Item2 + 1;
                    if (item.Item1 - 1 >= 0)
                    {
                        if (dist < distances[item.Item1 - 1])
                        {
                            distances[item.Item1 - 1] = dist;
                            q.Enqueue((item.Item1 - 1, dist), dist);
                        }
                    }
                    if (item.Item1 + 1 <= 100000)
                    {
                        if (dist < distances[item.Item1 + 1])
                        {
                            distances[item.Item1 + 1] = dist;
                            q.Enqueue((item.Item1 + 1, dist), dist);
                        }
                    }
                    if (item.Item1 * 2 <= 100000)
                    {
                        dist = item.Item2;
                        if (dist < distances[item.Item1 * 2])
                        {
                            distances[item.Item1 * 2] = dist;
                            q.Enqueue((item.Item1 * 2, dist), dist);
                        }
                    }
                }
            }
            Search(NK[0]);

            Console.WriteLine(distances[NK[1]]);
            //for(int i = 0; i < Points.Length; i++)
            //{
            //    Console.WriteLine(NK[0] +" -> " + Points[i]+" : " +distances[Points[i]]);
            //}
        }
    }
}
