namespace BaekjoonProj
{
    internal class _10811
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = Enumerable.Range(1, NM[0]).ToArray();
            int temp;
            for (int i = 0; i < NM[1]; i++)
            {
                int[] IJ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                IJ[0]--; IJ[1]--;
                for(int j = 0; j < (int)Math.Ceiling((float)(IJ[1] - IJ[0]) / 2f); j++)
                {
                    temp = N[IJ[0]+j];
                    N[IJ[0]+j] = N[IJ[1] - j];
                    N[IJ[1] - j] = temp;
                }
            }
            for (int i = 0; i < NM[0]; i++)
            {
                sb.Append(N[i] + " ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
