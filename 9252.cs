namespace BaekjoonProj
{
    internal class _9252
    {
        public static void Run(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int N = input1.Length;
            int N2 = input2.Length;
            int[,] DP = new int[N + 1, N2 + 1];
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N2; j++)
                {
                    if (input1[i - 1] == input2[j - 1])
                    {
                        DP[i, j] = DP[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        DP[i, j] = Math.Max(DP[i - 1, j], DP[i, j - 1]);
                    }
                }

            }
            int length = DP[N, N2];
            int x = N2, y = N;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(length.ToString());
            Stack<char> stack = new Stack<char>();
            while (DP[y, x] != 0)
            {
                if (DP[y - 1, x] == DP[y, x])
                {
                    y--;
                }
                else if (DP[y, x - 1] == DP[y, x])
                {
                    x--;
                }
                else
                {
                    stack.Push(input1[y - 1]);
                    x--; y--;
                }
            }
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            Console.WriteLine(sb);
        }
    }
}
