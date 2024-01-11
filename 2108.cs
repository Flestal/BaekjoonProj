namespace BaekjoonProj
{
    internal class _2108
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> ints = new List<int>();
            int min=int.MaxValue, max=int.MinValue;
            for(int i=0;i<N;i++)
            {
                int num = int.Parse((Console.ReadLine()));
                if(num < min) min = num;
                if(num > max) max = num;
                ints.Add(num);
            }
            ints.Sort();
            int avg, mid, freq, range;
            avg = (int)Math.Round(ints.Average(), MidpointRounding.AwayFromZero);
            mid = ints[(int)Math.Floor(ints.Count/2f)];
            Dictionary<int, int> freqDict = ints.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            freqDict=freqDict.OrderByDescending(kv => kv.Value).ThenBy(kv=>kv.Key).ToDictionary(kv=>kv.Key,kv=>kv.Value);
            if(freqDict.Count > 1 && freqDict.ElementAt(0).Value == freqDict.ElementAt(1).Value)
            {
                freq = freqDict.ElementAt(1).Key;
            }
            else
            {
                freq = freqDict.ElementAt(0).Key;
            }
            range = max - min;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(avg.ToString())
                .AppendLine(mid.ToString())
                .AppendLine(freq.ToString())
                .AppendLine(range.ToString());
            Console.WriteLine(sb);
        }
    }
}
