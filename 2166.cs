namespace BaekjoonProj
{
    internal class _2166
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[][] ints = new long[N][];
            for(int i=0;i<N; i++)
            {
                long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                ints[i] = input;
            }
            long sum1 = 0,sum2 = 0;
            for(int i = 0; i < N-1; i++)
            {
                int j = N - i - 1;
                sum1 += ints[i][0] * ints[i + 1][1];
                sum2 += ints[j][0] * ints[j - 1][1];
            }
            sum1 += ints[N - 1][0] * ints[0][1];
            sum2 += ints[0][0] * ints[N - 1][1];
            double res = ((double)Math.Abs(sum2 - sum1))/2;
            Console.WriteLine(res.ToString("0.0"));
        }
    }
}
