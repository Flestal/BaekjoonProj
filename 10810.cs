namespace BaekjoonProj
{
    internal class _10810
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = new int[NM[0]];
            for(int i=0; i < NM[1]; i++)
            {
                int[] IJK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                IJK[0]--; IJK[1]--;
                for(int j = IJK[0]; j <= IJK[1]; j++)
                {
                    N[j] = IJK[2];
                }
            }
            for(int i = 0; i < NM[0]; i++)
            {
                sb.Append(N[i] + " ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
