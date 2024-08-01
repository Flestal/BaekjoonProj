namespace BaekjoonProj
{
    internal class _11279
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            for(int i=0; i < N; i++)
            {
                int A=int.Parse(Console.ReadLine());
                if (A != 0)
                {
                    priorityQueue.Enqueue(A, int.MaxValue - A);
                }else if (A == 0)
                {
                    if (priorityQueue.Count == 0)
                    {
                        sb.AppendLine("0");
                        continue;
                    }
                    sb.AppendLine(priorityQueue.Dequeue().ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
