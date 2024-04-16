
namespace BaekjoonProj
{
    internal class _2720
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < T; i++)
            {
                int C = int.Parse(Console.ReadLine());
                sb.Append(C / 25).Append(' ');
                C %= 25;
                sb.Append(C / 10).Append(' ');
                C %= 10;
                sb.Append(C/5).Append(' ');
                C %= 5;
                sb.AppendLine(C.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
