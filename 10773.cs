namespace BaekjoonProj
{
    internal class _10773
    {
        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for(int i=0; i<K; i++)
            {
                int A = int.Parse(Console.ReadLine());
                if(A == 0) { stack.Pop(); }
                else{ stack.Push(A); }
            }
            int sum = 0;
            while(stack.Count>0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine(sum);
        }
    }
}
