namespace BaekjoonProj
{
    internal class _16928
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[] visited = new bool[101];
            //1~N개 점, 0번 무시
            Dictionary<int, int> UV = new Dictionary<int, int>();
            //UV[0] -> UV[1]로 강제이동
            for(int i = 0; i < NM[0] + NM[1]; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                UV.Add(input[0], input[1]);
            }
            int order = 1;
            Queue<(int,int)> q = new Queue<(int,int)>();//(현재칸, 반복깊이)
            int d = 0,SnakeLadder;
            void BFS(int cur,int depth)
            {
                if (cur == 100)
                {
                    d = depth;
                }
                for(int i=1;i<=6;i++)
                {
                    SnakeLadder = 0;
                    if (UV.ContainsKey(cur+i))
                    {
                        SnakeLadder = UV[cur+i]-(cur+i);
                    }
                    if (cur + i + SnakeLadder>100||visited[cur+i + SnakeLadder])
                    {
                        continue;
                    }
                    visited[i + cur + SnakeLadder] = true;
                    q.Enqueue((i+cur + SnakeLadder, depth+1));
                }
            }
            visited[1] = true;
            q.Enqueue((1,0));
            while (q.Count > 0&&d==0)
            {
                (int, int) item = q.Dequeue();
                BFS(item.Item1,item.Item2);
            }
            Console.WriteLine(d);
        }
    }
}
