namespace BaekjoonProj
{
    internal class _10813
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = Enumerable.Range(1, NM[0]).ToArray();
            int temp;
            for(int i=0; i < NM[1]; i++)
            {
                int[] IJ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                IJ[0]--; IJ[1]--;
                temp = N[IJ[0]];
                N[IJ[0]] = N[IJ[1]];
                N[IJ[1]] = temp;
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
