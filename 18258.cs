namespace BaekjoonProj
{
    internal class _18258
    {
        public static void Run(string[] args)
        {
            Queue<int> q = new Queue<int>();
            int lastQ=-1;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch(command[0])
                {
                    case "push":
                        lastQ = int.Parse(command[1]);
                        q.Enqueue(lastQ);
                        break;
                    case "pop":
                        if (q.Count > 0) sb.AppendLine(q.Dequeue().ToString());
                        else sb.AppendLine("-1"); 
                        break;
                    case "size":
                        sb.AppendLine(q.Count.ToString());
                        break;
                    case "empty":
                        if (q.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "front":
                        if (q.Count > 0) sb.AppendLine(q.Peek().ToString());
                        else sb.AppendLine("-1");
                        break;
                    case "back":
                        if (q.Count > 0) sb.AppendLine(lastQ.ToString());
                        else sb.AppendLine("-1");
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
