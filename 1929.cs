namespace BaekjoonProj
{
    internal class _1929
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] ints = new int[NM[1]-NM[0] +1];
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < NM[1] - NM[0] + 1; i++)
            {
                ints[i] = NM[0] + i;
            }
            int sqrt = (int)Math.Ceiling(Math.Sqrt(NM[1]));
            for(int i=2; i <= sqrt; i++)
            {
                for(int j=0; j < ints.Length; j++)
                {
                    if (ints[j] == -1) continue;
                    if (ints[j] % i == 0 && ints[j] > i)
                    {
                        ints[j] = -1;
                        continue;
                    }
                    if (ints[j] == 1)
                    {
                        ints[j] = -1;
                        continue;
                    }
                }
            }
            for(int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == -1) continue;
                sb.AppendLine(ints[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
