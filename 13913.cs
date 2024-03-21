namespace BaekjoonProj
{
    internal class _13913
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (NK[0] == NK[1])
            {
                sb.AppendLine("0");
                sb.Append(NK[0]);
                Console.WriteLine(sb);
                return;
            }
            if (NK[0] > NK[1])
            {
                sb.AppendLine((NK[0] - NK[1]).ToString());
                sb.Append(NK[0]);
                for(int i = NK[0]-1; i >= NK[1]; i--)
                {
                    sb.Append(' ').Append(i);
                }
                Console.WriteLine(sb);
                return;
            }

            //int[] DP = new int[110001];
            int[] DP = Enumerable.Repeat(-1, 110001).ToArray();
            DP[NK[0]] = -1;
            Queue<int> q = new Queue<int>();
            void BFS(int cur)
            {
                if (cur - 1 >= 0&&DP[cur-1] == -1)
                {
                    DP[cur - 1] = cur;
                    if (cur-1 == NK[1])
                    {
                        q.Clear();
                        return;
                    }
                    q.Enqueue(cur-1);
                }
                if (cur + 1 <= 110000&&DP[cur + 1] == -1)
                {
                    DP[cur+1] = cur;
                    if (cur+1 == NK[1])
                    {
                        q.Clear();
                        return;
                    }
                    q.Enqueue(cur+1);
                }
                if (cur * 2 <= 110000&&DP[cur * 2] == -1)
                {
                    DP[cur * 2] = cur;
                    if (cur*2 == NK[1])
                    {
                        q.Clear();
                        return;
                    }
                    q.Enqueue(cur * 2);
                }
            }
            DP[NK[0]] = -100;
            q.Enqueue(NK[0]);
            while (q.Count > 0)
            {
                BFS(q.Dequeue());
            }
            int temp = NK[1];
            int cnt = 0;
            Stack<int> stack = new Stack<int>();
            while (temp != -100)
            {
                cnt++;
                stack.Push(temp);
                temp = DP[temp];
            }
            
            sb.AppendLine((cnt-1).ToString());
            sb.Append(stack.Pop());
            while (stack.Count > 0)
            {
                sb.Append(' ').Append(stack.Pop());
            }
            Console.WriteLine(sb);
        }
    }
}
