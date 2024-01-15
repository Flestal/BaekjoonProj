namespace BaekjoonProj
{
    internal class _15649
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Enumerable.Range(1, NM[0]).ToArray();
            bool[] visited = new bool[8];
            int[] order = new int[8];
            void nPr(int cur)
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
                    if (visited[i])
                    {
                        continue;
                    }
                    visited[i] = true;
                    order[cur] = i;
                    nPr(cur + 1);
                    visited[i] = false;
                }
            }
            nPr(0);
            sb.Remove(sb.Length - 1,1);
            Console.WriteLine(sb);
        }
    }
}
