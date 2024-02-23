namespace BaekjoonProj
{
    internal class _1450
    {
        public static void Run(string[] args)
        {

            int[] NC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] W = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int[,] DP = new int[NC[0]+1,NC[1] + 1];
            int[] DP = new int[NC[1] + 1];
            //for(int i = 0; i <= NC[0]; i++)
            //{
            //    DP[i, 0] = 1;
            //}
            for(int i = 0; i <= NC[1]; i++)
            {
                DP[i] = 1;
            }

            for (int i = 1; i <= NC[0]; i++)
            {
                for (int j = NC[1]; j >= 0; j--)
                {
                    if (j >= W[i - 1])
                    {
                        DP[j] += DP[j - W[i - 1]];
                    }
                }
            }
            Console.WriteLine(DP[NC[1]]);
        }
    }
}
