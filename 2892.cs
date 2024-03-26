namespace BaekjoonProj
{
    internal class _1874
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Stack<int> stack = new Stack<int>();
            int[] ints = new int[N];
            for(int i=0; i < N; i++)
            {
                ints[i]= int.Parse(Console.ReadLine());
            }
            int a = 0;
            int plus = 0, minus = 0;
            for(int i = 1; i <= N; i++)
            {
                stack.Push(i);
                sb.AppendLine("+");
                plus++;
                while (stack.Count>0&&stack.Peek() == ints[a])
                {
                    stack.Pop();
                    sb.AppendLine("-");
                    minus++;
                    a++;
                }
            }
            if (plus != minus)
            {
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine(sb);
        }
    }
}
