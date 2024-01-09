namespace BaekjoonProj
{
    internal class _2231
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int n_, sum;
            
            for (int i = N - 99; i <= N; i++)
            {
                if (i <= 0) continue;
                n_ = i;
                sum = 0;
                while (n_ > 0)
                {
                    sum += n_ % 10;
                    n_ /= 10;
                }
                if ((i + sum) == N)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("0");
        }
    }
}
