using System.Collections;

namespace BaekjoonProj
{
    internal class _1620
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<string,int> dict = new Dictionary<string,int>();
            for(int i=0;i<NM[0]; i++)
            {
                dict.Add(Console.ReadLine(), i+1);
            }
            Dictionary<int, string> rev = dict.ToDictionary(x => x.Value, x => x.Key);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < NM[1]; i++)
            {
                string s = Console.ReadLine();
                if(int.TryParse(s, out int n))
                {
                    sb.AppendLine(rev[n].ToString());
                }
                else
                {
                    sb.AppendLine(dict[s].ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}
