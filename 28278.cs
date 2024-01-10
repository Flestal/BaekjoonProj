namespace BaekjoonProj
{
    internal class _28278
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<N;i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (int.Parse(command[0]))
                {
                    case 1:
                        stack.Push(int.Parse(command[1]));
                        break;
                    case 2:
                        if (stack.Count > 0) sb.AppendLine(stack.Pop().ToString());
                        else sb.AppendLine("-1");
                        break;
                    case 3:
                        sb.AppendLine(stack.Count.ToString());
                        break;
                    case 4:
                        if (stack.Count > 0) sb.AppendLine("0");
                        else sb.AppendLine("1");
                        break;
                    case 5:
                        if (stack.Count > 0) sb.AppendLine(stack.Peek().ToString());
                        else sb.AppendLine("-1");
                        break;
                }
            }
            Console.Write(sb);
        }
    }
}
