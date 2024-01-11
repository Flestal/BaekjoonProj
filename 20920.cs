namespace BaekjoonProj
{
    internal class _20920
    {
        public static void Run(string[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<string> list = new List<string>();
            for(int i=0;i<NM[0];i++)
            {
                string word = Console.ReadLine();
                if (word.Length < NM[1]) continue;
                list.Add(word);
            }
            Dictionary<string, int> freqDict
                = list.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
            freqDict
                =freqDict.OrderByDescending(kv => kv.Value)
                .ThenByDescending(kv=>kv.Key.Length)
                .ThenBy(kv=>kv.Key)
                .ToDictionary(kv=>kv.Key,kv=>kv.Value);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(KeyValuePair<string, int> kv in freqDict)
            {
                sb.AppendLine(kv.Key);
            }
            Console.WriteLine(sb);
        }
    }
}
