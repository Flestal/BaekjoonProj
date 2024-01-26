namespace BaekjoonProj
{
    internal class _4134
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int _ = 0; _ < T; _++)
            {
                long N = long.Parse(Console.ReadLine());
                long nn = N;
                long sqrt;
                bool flag = true, flag2 = true;
                if (N == 0 || N == 1 || N == 2)
                {
                    sb.AppendLine("2");
                    continue;
                }
                while (flag)
                {
                    sqrt = (long)Math.Ceiling(Math.Sqrt(nn));
                    flag2 = true;
                    for (long i = 2; i <= sqrt; i++)
                    {
                        if (nn % i == 0)
                        {
                            flag2 = false;
                            break;
                        }
                    }
                    if (flag2)
                    {
                        sb.AppendLine(nn.ToString());
                        flag = false;
                        break;
                    }
                    nn++;
                }
            }
            Console.WriteLine(sb);
        }
    }
}
