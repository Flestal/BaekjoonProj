namespace BaekjoonProj
{
    internal class _2775
    {
        public static void Run(string[] args)
        {
            int[] sum_curr;
            int[] sum_prev;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            for(int ii = 0; ii < T; ii++)
            {
                sum_curr = new int[14];
                sum_prev = new int[14] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                for (int i=0;i<k;i++)
                {
                    sum_curr[0] = 1;
                    for(int j = 1; j < n; j++)
                    {
                        sum_curr[j] = sum_curr[j - 1] + sum_prev[j];
                    }
                    sum_prev = sum_curr;
                }
                sb.Append(sum_curr[n - 1]);
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
