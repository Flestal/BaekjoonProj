namespace BaekjoonProj
{
    internal class _10986
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] A = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] sum = new long[NM[0]];
            long[] per = new long[NM[1]];
            sum[0] = A[0];
            per[0] = 1;
            for (int i = 1; i < NM[0]; i++)
            {
                sum[i] = sum[i - 1] + A[i];
            }
            int index;
            for(int i = 0; i < NM[0]; i++)
            {
                index = (int)(sum[i] % NM[1]);
                per[index]++;
            }
            long res = 0;
            for(int i = 0; i < NM[1]; i++)
            {
                res += (per[i] * (per[i]-1))/2;
            }
            Console.WriteLine(res);
        }
    }
}
