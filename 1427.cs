namespace BaekjoonProj
{
    internal class _1427
    {
        public static void Run(string[] args)
        {
            string s = Console.ReadLine();
            int[] ints = new int[10];
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0; i<s.Length; i++)
            {
                int n = s[i] - '0';
                ints[n]++;
            }
            for(int i = 9; i >= 0; i--)
            {
                if (ints[i] == 0) continue;
                for(int j = 0; j < ints[i]; j++)
                {
                    sb.Append(i);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
