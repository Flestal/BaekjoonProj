namespace BaekjoonProj
{
    internal class _1697
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NK[0], K = NK[1];
            bool[] visited = new bool[100001];//한번 방문한 곳에 또 방문하면 같은 결과만 나옴

            Queue<(int, int, int)> q = new Queue<(int, int, int)>();
            bool endFlag = false;
            int res=0;
            void BFS(int n_,int k_,int depth)
            {
                if (n_ == k_)
                {
                    res = depth;
                    endFlag = true;
                    return;
                }
                if (n_ - 1 >= 0 && !visited[n_ - 1])
                {
                    visited[n_ - 1] = true;
                    q.Enqueue((n_ - 1, k_, depth + 1));
                }
                if (n_ + 1 < 100001 && !visited[n_ + 1])
                {
                    visited[n_ + 1] = true;
                    q.Enqueue((n_ + 1, k_, depth + 1));
                }
                if (n_ * 2 < 100001 && !visited[n_ * 2])
                {
                    visited[n_ * 2] = true;
                    q.Enqueue((n_ * 2, k_, depth + 1));
                }

            }
            visited[N] = true;
            q.Enqueue((N, K, 0));
            while (q.Count>0&&!endFlag)
            {
                (int, int, int) item = q.Dequeue();
                BFS(item.Item1, item.Item2, item.Item3);
            }
            Console.WriteLine(res);
        }
    }
}
