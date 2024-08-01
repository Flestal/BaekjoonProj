namespace BaekjoonProj
{
    internal class _21921
    {
        public static void Run(string[] args)
        {
            int[] NX = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] J_ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] DP = new int[NX[0]+1];
            DP[1] = J_[0];
            int sum;
            int sum_max = 0;
            int days = 0;
            for(int i = 1; i < NX[0]; i++)
            {
                DP[i+1] = J_[i] + DP[i];
                if (i >= NX[1]-1)
                {
                    sum = DP[i+1] - DP[i - NX[1]+1];
                    if(sum > sum_max)
                    {
                        sum_max = sum;
                        days = 1;
                    }else if (sum == sum_max)
                    {
                        days++;
                    }
                }
            }
            if (sum_max == 0)
            {
                Console.WriteLine("SAD");
                return;
            }
            Console.WriteLine(sum_max);
            Console.WriteLine(days);
        }
    }
}
