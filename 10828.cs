
namespace BaekjoonProj
{
    internal class _10828
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < N; i++)
            {
                string[] data = Console.ReadLine().Split();
                switch(data[0])
                {
                case "push":
                    stack.Push(int.Parse(data[1]));
                    break;
                case "pop":
                    if (stack.Count > 0) sb.AppendLine(stack.Pop().ToString());
                    else sb.AppendLine("-1");
                    break;
                case "size":
                    sb.AppendLine(stack.Count.ToString());
                    break;
                case "empty":
                    if (stack.Count > 0) sb.AppendLine("0");
                    else sb.AppendLine("1");
                    break;
                case "top":
                    if (stack.Count > 0) sb.AppendLine(stack.Peek().ToString());
                    else sb.AppendLine("-1");
                    break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
