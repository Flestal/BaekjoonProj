namespace BaekjoonProj
{
    internal class _12920
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < NM[0]; i++)
            {
                int[] VCK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int k = VCK[2];
                for(int j=1;k>0; j*=2)//[1,2,4,...나머지]의 배율로 묶음상품
                {
                    int k_ = Math.Min(k, j);
                    list.Add(new int[] { VCK[0] * k_, VCK[1]*k_});
                    k -= j;
                }
            }
            int[] DP_ = new int[NM[1]+1];
            
            for(int i=0;i< list.Count; i++)
            {
                for(int j = DP_.Length-1; j >=0; j--)
                {//1차원 배열에서 냅색은 역순
                    if (list[i][0] <= j)
                    {
                        DP_[j] =
                            Math.Max(DP_[j - list[i][0]] + list[i][1], DP_[j]);
                    }
                }
            }
            Console.WriteLine(DP_[DP_.Length - 1]);
        }
    }
}
