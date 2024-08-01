namespace BaekjoonProj
{
    internal class _5217
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            for(int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine());
                sb.Append("Pairs for " + N + ": ");
                for(int i = 1; i < (N / 2)+1; i++)
                {
                    int j = N - i;
                    if (i == j) break;
                    sb.Append(i + " " + j+", ");
                }
                if (sb[sb.Length - 1] == ' ' && sb[sb.Length - 2] == ':')
                {
                    sb.Append("  ");
                }
                sb.Remove(sb.Length - 2, 2);
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
