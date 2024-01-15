namespace BaekjoonProj
{
    internal class _15652
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Enumerable.Range(1, NM[0]).ToArray();
            int[] order = new int[8];
            void nPir(int cur)
            {
                if (cur == NM[1])
                {
                    for(int i = 0; i < NM[1]; i++)
                    {
                        sb.Append(arr[order[i]]).Append(' ');
                    }
                    sb.Append('\n');
                    return;
                }
                for(int i = 0; i < NM[0]; i++)
                {
                    if (cur > 0 && order[cur - 1] > i)
                    {
                        continue;
                    }
                    order[cur] = i;
                    nPir(cur + 1);
                }
            }
            nPir(0);
            sb.Remove(sb.Length - 1,1);
            Console.WriteLine(sb);
        }
    }
}
