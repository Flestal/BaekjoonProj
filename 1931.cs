namespace BaekjoonProj
{
    internal class _1931
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] C = new int[N][];
            for (int i = 0; i < N; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                C[i] = input;
            }
            C = C.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
            int cnt = 0;
            int start = 0, stop = 0, index = 0;
            for (int i = 0; i < N; i++)
            {
                if (C[i][0] >= stop)
                {
                    start = C[i][0];
                    stop = C[i][1];
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
