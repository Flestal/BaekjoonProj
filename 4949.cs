namespace BaekjoonProj
{
    internal class _4949
    {
        public static void Run(string[] args)
        {
            Stack<char> stack;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while(true)
            {
                string command = Console.ReadLine();
                if(command == ".") { break; }
                stack = new Stack<char>();
                foreach(char c in command)
                {
                    switch (c)
                    {
                        case '(':
                            stack.Push(c);
                            break;
                        case ')':
                            if (stack.Count > 0 && stack.Peek() == '(')
                                stack.Pop();
                            else
                                stack.Push(c);
                            break;
                        case '[':
                            stack.Push(c);
                            break;
                        case ']':
                            if(stack.Count>0&&stack.Peek() == '[')
                                stack.Pop();
                            else
                                stack.Push(c);
                            break;
                        case '.':
                            if (stack.Count > 0) sb.AppendLine("no");
                            else sb.AppendLine("yes");
                            stack.Clear();
                            break;
                    }
                }
            }
            Console.Write(sb);
        }
    }
}
