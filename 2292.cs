namespace BaekjoonProj
{
    internal class _2292
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int depth = 1;N -= 1;
            while(N>0)
            {
                N -= depth * 6;
                depth++;
            }
            Console.WriteLine(depth);
        }
    }
}
