namespace BaekjoonProj
{
    internal class _24511
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int M = int.Parse(Console.ReadLine());
            int[] C = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> s = new Stack<int>();
            Queue<int> q = new Queue<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < N; i++)
            {
                if (A[i] == 0)
                {
                    s.Push(B[i]);
                }
            }
            while(s.Count>0)
            {
                q.Enqueue(s.Pop());
            }
            for(int i = 0; i < C.Length; i++)
            {
                q.Enqueue(C[i]);
                sb.Append(q.Dequeue()).Append(" ");
            }
            Console.Write(sb);
        }
    }
}
