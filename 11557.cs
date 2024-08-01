namespace BaekjoonProj
{
    internal class _11557

    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            Dictionary<string, int> map = new Dictionary<string, int>();
            for(int i=0; i < T; i++)
            {
                map.Clear();
                int N = int.Parse(Console.ReadLine());
                for (int j = 0; j < N; j++)
                {
                    string[] input = Console.ReadLine().Split();
                    if (map.ContainsKey(input[0]))
                        map[input[0]] += int.Parse(input[1]);
                    else
                        map.Add(input[0], int.Parse(input[1]));
                }
                sb.AppendLine(map.MaxBy(x=>x.Value).Key);
            }
            Console.WriteLine(sb);
        }
    }
}
