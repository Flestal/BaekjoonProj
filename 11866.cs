namespace BaekjoonProj
{
    internal class _11866
    {
        public static void Run(string[] args)
        {
            Queue<int> q = new Queue<int>();
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<");
            for (int i = 1; i <= NK[0]; i++)
            {
                q.Enqueue(i);
            }
            while(q.Count > 0)
            {
                for(int i = 1; i < NK[1]; i++)
                {
                    q.Enqueue(q.Dequeue());
                }
                sb.Append(q.Dequeue()+", ");
            }
            sb.Remove(sb.Length - 2,2);
            sb.Append(">");
            Console.WriteLine(sb);
        }
    }
}
