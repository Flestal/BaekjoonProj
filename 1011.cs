namespace BaekjoonProj
{
    internal class _1011
    {
        public static void Run(string[] args)
        {
            
            int[] board = new int[92681];
            board[1] = 1;
            board[2] = 2;
            int a = 2;
            for(int i=3; i<92680; i+=2)
            {
                board[i] = a*a;
                board[i + 1] = a * a + a;
                a++;
            }
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<T; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int c = xy[1] - xy[0];
                if (c > 2147441940)
                {
                    sb.AppendLine("92681");
                    continue;
                }
                int idx = 0;
                int revIdx = 92680;
                while (board[idx] < c && board[revIdx]>=c)
                {
                    idx++;
                    revIdx--;
                }
                if (board[idx] >= c) { sb.AppendLine(idx.ToString());continue; }
                if (board[revIdx] < c) { sb.AppendLine((revIdx+1).ToString());continue; }
            }
            Console.WriteLine(sb);
        }
    }
}
