namespace BaekjoonProj
{
    internal class _1193
    {
        public static void Run(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int i, low = 0,remain;
            for(i=0; i<X; i++)
            {
                if (low + i >= X) break;
                low+=i;
            }
            remain = X - low;
            if (i % 2 == 0)
            {
                Console.WriteLine(remain + "/" + (i - remain + 1));
            }
            else
            {
                Console.WriteLine((i - remain + 1) + "/" + remain);
            }
            
        }
    }
}
