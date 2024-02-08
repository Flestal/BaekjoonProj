
namespace BaekjoonProj
{
    internal class _2581
    {
        public static void Run(string[] args)
        {
            int[] ints = Enumerable.Repeat(1, 10001).ToArray();
            ints[0] = 0; ints[1] = 0;
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (j >= i) break;
                    if (i > j && i % j == 0)
                    {
                        ints[i] = 0;
                    }
                }
            }
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int min = -1;int sum = 0;
            for(int i = M; i <= N; i++)
            {
                if (ints[i] == 1)
                {
                    if (min == -1) min = i;
                    sum += i;
                }
            }
            if (min == -1)
            {
                Console.WriteLine(min);
                return;
            }
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
    }
}
