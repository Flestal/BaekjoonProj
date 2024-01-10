namespace BaekjoonProj
{
    internal class _12789
    {
        public static void Run(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int N = int.Parse(Console.ReadLine());
            int[] Numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> line = new Stack<int>();
            for (int i = Numbers.Length - 1; i >= 0; i--)
            {
                line.Push(Numbers[i]);
            }
            int cursor = 1;
            while (line.Count > 0)
            {
                if (line.Peek() == cursor)
                {
                    line.Pop();
                    cursor++;
                }else if(stack.Count > 0&&stack.Peek()==cursor)
                {
                    stack.Pop();
                    cursor++;
                }
                else
                {
                    stack.Push(line.Pop());
                }
            }
            while(stack.Count > 0)
            {
                if(stack.Peek() == cursor)
                {
                    stack.Pop();
                    cursor++;
                }
                else
                {
                    break;
                }
            }
            bool res = (line.Count==0&stack.Count==0);
            if (res) Console.WriteLine("Nice");
            else Console.WriteLine("Sad");
        }
    }
}
