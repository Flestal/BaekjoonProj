namespace BaekjoonProj
{
    internal class _1002
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<T; i++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (line[3] == line[0] && line[4] == line[1] && line[5] == line[2])
                {
                    sb.AppendLine("-1");
                    continue;
                }
                int xx = Math.Abs(line[3] - line[0]);
                int yy = Math.Abs(line[4] - line[1]);
                double len = Math.Sqrt(xx * xx + yy * yy);
                int radsum, raddiff;
                radsum = line[2] + line[5];
                raddiff = Math.Abs(line[5] - line[2]);
                int result = 0;
                if (len > radsum)
                {
                    result = 0;
                }
                else if (len == radsum)
                {
                    result = 1;
                }
                else
                {
                    if (len > raddiff)
                    {
                        result = 2;
                    }
                    else if (len < raddiff)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = 1;
                    }
                }
                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
