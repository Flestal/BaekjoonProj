namespace BaekjoonProj
{
    internal class _5086
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM;
            while (true)
            {
                NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (NM[0] == 0 && NM[1]==0)
                {
                    break;
                }
                else if (NM[0] > NM[1] && NM[0] % NM[1] == 0)
                {
                    sb.AppendLine("multiple");
                }else if (NM[0] < NM[1] && NM[1] % NM[0] == 0)
                {
                    sb.AppendLine("factor");
                }
                else
                {
                    sb.AppendLine("neither");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
