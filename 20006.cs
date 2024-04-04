
using System.Security.Cryptography.X509Certificates;

namespace BaekjoonProj
{
    internal class _20006
    {
        public struct Match
        {
            public int min;
            public int max;
            public string list;
            public int count;
            public string[] GetStrings()
            {
                return list.Split(',').OrderBy(x=>x).ToArray();
            }
            public Match(int id, string start)
            {
                this.min = id-10;
                this.max = id+10;
                this.list = start;
                this.count = 1;
            }
            public void Append(string str)
            {
                this.list += ',' + str;
                this.count++;
            }
        }
        public static void Run(string[] args)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] PM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<string,int> map = new Dictionary<string,int>();
            List<Match> matches = new List<Match>();
            for(int i = 0; i < PM[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                int id = int.Parse(input[0]);
                map.Add(input[1], id);
                bool flag = true;
                for(int j=0;j<matches.Count;j++)
                {
                    Match m = matches[j];
                    if (id >= m.min && id <= m.max && m.count < PM[1])
                    {
                        flag = false;
                        m.list += ',' + input[1];
                        m.count++;
                        matches[j] = m;
                        break;
                    }
                }
                if (flag)
                {
                    matches.Add(new Match(id, input[1]));
                }
            }
            for(int i = 0; i < matches.Count; i++)
            {
                string[] strings = matches[i].GetStrings();
                if (matches[i].count == PM[1])
                    sb.AppendLine("Started!");
                else
                    sb.AppendLine("Waiting!");
                foreach(string s in strings)
                {
                    sb.AppendLine(map[s] + " " + s);
                }
            }
            
            Console.WriteLine(sb);
        }
    }
}
