namespace BaekjoonProj
{
    internal class _2559
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sum = new int[N.Length];
            sum[0] = N[0];
            for(int i=1; i<N.Length; i++)
            {
                sum[i] = sum[i - 1] + N[i];
            }
            int res = sum[NK[1] - 1];
            for(int j = NK[1]; j < N.Length; j++)
            {
                if (sum[j] - sum[j - NK[1]] > res) { res = sum[j] - sum[j - NK[1]]; }
            }
            Console.WriteLine(res);
        }
    }
}
