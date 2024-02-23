
namespace BaekjoonProj
{
    internal class _2630
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] board = new int[N][];
            for(int i=0;i<N; i++)
            {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            int[] colors = new int[2];
            void GetColor(int x,int y,int size)
            {
                
                int color = board[x][y];
                if (size == 1)
                {
                    colors[color]++;
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
                    colors[color]++;
                    return;
                }
                else
                {
                    int size_ = size / 2;
                    GetColor(x, y, size_);
                    GetColor(x + size_, y, size_);
                    GetColor(x, y + size_, size_);
                    GetColor(x + size_, y + size_, size_);
                }
            }
            GetColor(0, 0, N);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);

        }
    }
}
