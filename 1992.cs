
namespace BaekjoonProj
{
    internal class _1992
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[][] board = new int[N][];
            for(int i=0;i<N; i++)
            {
                string input= Console.ReadLine();
                int[] ii = new int[N];
                for(int j = 0; j < N; j++)
                {
                    ii[j] = int.Parse(input[j] + " ");
                }
                board[i] = ii;
            }
            int[] colors = new int[2];
            void GetColor(int x,int y,int size)
            {
                
                int color = board[x][y];
                if (size == 1)
                {
                    sb.Append(color);
                    return;
                }
                bool flag = true;
                for(int j = y; j < y + size; j++)
                {
                    if (!flag) break;
                    for(int i=x; i < x + size; i++)
                    {
                        if (board[i][j] != color)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    sb.Append(color);
                    return;
                }
                else
                {
                    int size_ = size / 2;
                    sb.Append('(');
                    GetColor(x, y, size_);
                    GetColor(x, y + size_, size_);
                    GetColor(x + size_, y, size_);
                    GetColor(x + size_, y + size_, size_);
                    sb.Append(')');
                }
            }
            GetColor(0, 0, N);
            Console.WriteLine(sb);
        }
    }
}
