namespace BaekjoonProj
{
    internal class _4892
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int n4;
            int i = 0;
            while(true)
            {
                i++;
                int N = int.Parse(Console.ReadLine());
                if (N == 0) break;
                sb.Append(i + ". ");
                n4 = 0;
                if (N % 2 == 0)
                {
                    sb.Append("even ");
                    n4 = N / 2;
                }
                else
                {
                    sb.Append("odd ");
                    n4 = (N - 1) / 2;
                }
                sb.AppendLine(n4.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
