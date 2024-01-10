namespace BaekjoonProj
{
    internal class _2164
    {
        public static void Run(string[] args)
        {
            Queue<int> q = new Queue<int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                q.Enqueue(i);
            }
            while(q.Count > 1)
            {
                q.Dequeue();
                q.Enqueue(q.Dequeue());
            }
            Console.WriteLine(q.Dequeue());
        }
    }
}
