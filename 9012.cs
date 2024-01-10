namespace BaekjoonProj
{
    internal class _9012
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<char> stack;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<N;i++)
            {
                string command = Console.ReadLine();
                stack = new Stack<char>();
                foreach(char c in command)
                {
                    if (c == '(')
                    {
                        stack.Push('(');
                    }
                    else if (c == ')')
                    {
                        if(stack.Count > 0 && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            stack.Push(')');
                        }
                    }
                }
                if (stack.Count > 0) sb.AppendLine("NO");
                else sb.AppendLine("YES");
            }
            Console.Write(sb);
        }
    }
}
