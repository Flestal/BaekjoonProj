namespace BaekjoonProj
{
    internal class _16139
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string S = Console.ReadLine();
            int[,] chars = new int[S.Length,26];//'a'=97
            chars[0, S[0] - 'a'] = 1;
            for(int i=1; i<S.Length; i++)
            {
                for(int j = 0; j < 26; j++)
                {
                    chars[i, j] = chars[i - 1, j];
                }
                chars[i, S[i] - 'a']++;
            }
            int q = int.Parse(Console.ReadLine());
            for(int _=0; _ < q; _++)
            {
                string[] input = Console.ReadLine().Split();
                char what = input[0][0];
                int start = int.Parse(input[1]);
                int stop = int.Parse(input[2]);
                int res = chars[stop, what - 'a'];
                if (start > 0)
                {
                    res -= chars[start - 1, what - 'a'];
                }
                sb.AppendLine(res.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
