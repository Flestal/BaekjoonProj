namespace BaekjoonProj
{
    internal class _11659
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] SUM = new int[N.Length];
            SUM[0] = N[0];
            for(int i=1;i<N.Length; i++)
            {
                SUM[i] = SUM[i - 1] + N[i];
            }
            for (int _ = 0; _ < NM[1]; _++)
            {
                int[] ij = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ij[0] -= 1; ij[1] -= 1;
                float len = (float)(ij[1] - ij[0] + 1);
                int res = SUM[ij[1]];
                if (ij[0] > 0) { res -= SUM[ij[0] - 1]; }
                sb.AppendLine(res.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
