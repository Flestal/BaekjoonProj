namespace BaekjoonProj
{
    internal class _15650
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Enumerable.Range(1, NM[0]).ToArray();
            bool[] visited = new bool[8];
            int[] order = new int[8];
            void nCr(int cur)
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
                for(int i = cur; i < NM[0]; i++)
                {
                    if (cur > 0 && order[cur-1]>=i)
                    {
                        continue;
                    }
                    order[cur] = i;
                    nCr(cur + 1);
                }
            }
            nCr(0);
            sb.Remove(sb.Length - 1,1);
            Console.WriteLine(sb);
        }
    }
}
