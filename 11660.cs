namespace BaekjoonProj
{
    internal class _11660
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] board = new int[NM[0]][];
            int[][] board_sum = new int[NM[0]+1][];
            for(int i = 0; i < NM[0]; i++)
            {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            board_sum[0] = new int[NM[0] + 1];
            for(int i = 1; i <= NM[0]; i++)
            {
                board_sum[i] = new int[NM[0]+1];
                for (int j = 1; j <= NM[0]; j++)
                {
                    board_sum[i][j] = board_sum[i][j - 1] + board[i-1][j-1];
                }
            }
            for (int _ = 0; _ < NM[1]; _++)
            {
                //배열 뒤집어진 상태, y1,x1,y2,x2로 받음
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int res = 0;
                for(int i = xy[0]; i <= xy[2]; i++)
                {
                    res += board_sum[i][xy[3]] - board_sum[i][xy[1] - 1];
                }
                sb.AppendLine(res.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
