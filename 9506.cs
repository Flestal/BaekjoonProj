namespace BaekjoonProj
{
    internal class _9506
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while(true)
            {
                int N = int.Parse(Console.ReadLine());
                if (N == -1) break;
                HashSet<int> temp = new HashSet<int>();
                for (int i = 1; i <= N / 2; i++)
                {
                    if (N % i == 0)
                    {
                        temp.Add(i);
                        temp.Add(N / i);
                    }
                }
                int[] g = temp.OrderBy(x => x).ToArray();
                int sum = 0;
                for(int i=0; i < g.Length-1; i++)
                {
                    sum+= g[i];
                }
                if (N == sum)
                {
                    string str = N + " = ";
                    for(int i=0; i < g.Length-1;i++)
                    {
                        str += g[i]+" + ";
                    }
                    str = str.Remove(str.Length - 3,3);
                    sb.AppendLine(str);
                }
                else
                {
                    sb.AppendLine(N + " is NOT perfect.");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
