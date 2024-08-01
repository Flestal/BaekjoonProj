namespace BaekjoonProj
{
    internal class _1138
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] res= Enumerable.Repeat(int.MaxValue, N).ToArray();
            int idx,j;
            for (int i = 1; i <= N; i++)
            {
                idx = 0;
                j = 0;
                while (j < line[i-1])
                {
                    if (res[idx]>i)
                    {
                        j++;
                    }
                    idx++;
                }
                while (res[idx] < i)
                {
                    idx++;
                }
                res[idx] = i;
            }
            foreach(int i in res)
            {
                sb.Append(i).Append(' ');
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
