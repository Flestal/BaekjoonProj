namespace BaekjoonProj
{
    internal class _11286
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            PriorityQueue<int, float> priorityQueue = new PriorityQueue<int, float>();
            for(int i=0; i < N; i++)
            {
                int A=int.Parse(Console.ReadLine());
                float abs = A;
                if (A < 0)
                {
                    abs = -A-0.5f;
                }
                if (A != 0)
                {
                    priorityQueue.Enqueue(A, abs);
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
