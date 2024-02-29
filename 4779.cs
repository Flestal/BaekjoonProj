using System.Globalization;

namespace BaekjoonProj
{
    internal class _4779
    {
        public static void Run(string[] args)
        {
            string tmp;
            string Cantor(int depth)
            {
                if(depth == 0)
                {
                    return "-";
                }
                else
                {
                    tmp = Cantor(depth - 1);
                    tmp += new string(' ', tmp.Length)+tmp;
                    return tmp;
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                int N=int.Parse(input);
                sb.AppendLine(Cantor(N));
            }
            Console.WriteLine(sb);
        }
    }
}
