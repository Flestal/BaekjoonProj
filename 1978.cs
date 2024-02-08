namespace BaekjoonProj
{
    internal class _1978
    {
        public static void Run(string[] args)
        {
            int[] ints = Enumerable.Repeat(1, 1001).ToArray();
            ints[0] = 0; ints[1] = 0;
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 2; j <= 32; j++)
                {
                    if (i > j && i % j == 0)
                    {
                        ints[i] = 0;
                    }
                }
            }
            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (ints[input[i]] == 1)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
