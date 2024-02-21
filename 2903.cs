namespace BaekjoonProj
{
    internal class _2903
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int a=2, b=1;
            a += b;
            for(int i=1;i<N;i++)
            {
                b = a - 1;
                a += b;
            }
            Console.WriteLine(a*a);
        }
    }
}
