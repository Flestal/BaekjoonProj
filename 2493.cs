namespace BaekjoonProj
{
    internal class _2493
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] res = new int[N];
            Stack<(int,int)> stack = new Stack<(int,int)>();
            (int,int) item;
            for(int i = N-1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek().Item1 < Arr[i])
                {
                    item = stack.Pop();
                    res[item.Item2] = i+1;
                }
                stack.Push((Arr[i],i));
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder(res[0].ToString());
            for(int i=1;i<N;i++)
            {
                sb.Append(" ").Append(res[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
