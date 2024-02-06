namespace BaekjoonProj
{
    internal class _1181
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string[] strings = new string[N];
            HashSet<string> set = new HashSet<string>();
            for(int i= 0; i < N; i++)
            {
                set.Add(Console.ReadLine());
            }
            strings = set.OrderBy(x => x.Length).ThenBy(x => x).ToArray();
            foreach(string s in strings)
            {
                sb.AppendLine(s);
            }
            Console.WriteLine(sb);
        }
    }
}
