namespace BaekjoonProj
{
    internal class _27433
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long F(int n)
            {
                if (n == 0 ||n == 1)
                {
                    return 1;
                }
                else
                {
                    return n*F(n - 1);
                }
            }
            Console.WriteLine(F(N));
        }
    }
}
