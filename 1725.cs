namespace BaekjoonProj
{
    internal class _1725
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[N];
            Stack<int> stack = new Stack<int>();
            int MaxRec = int.MinValue,rec;
            int H, height, pos;
            for(int i = 0; i < N; i++)
            {
                H = int.Parse(Console.ReadLine());
                ints[i] = H;
                while (stack.Count > 0)
                {
                    pos = stack.Peek();
                    if (ints[pos] >= ints[i])
                    {
                        stack.Pop();
                        height = ints[pos];
                        if (stack.Count == 0)
                        {
                            rec = height*i;
                        }
                        else
                        {
                            rec = height * (i-1-stack.Peek());
                        }
                        if (rec > MaxRec) 
                            MaxRec = rec;
                    }
                    else
                    {
                        break;
                    }
                }
                stack.Push(i);
            }
            //다 채우고 나서
            while (stack.Count > 0)
            {
                pos = stack.Pop();
                height = ints[pos];
                if (stack.Count == 0)
                {
                    rec = height * (N);
                }
                else
                {
                    rec = height * (N - 1 - stack.Peek());
                }
                if (rec > MaxRec)
                    MaxRec = rec;
            }
            Console.WriteLine(MaxRec);
        }
    }
}
