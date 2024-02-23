
namespace BaekjoonProj
{
    internal class _1780
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] board = new int[N][];
            for(int i=0;i<N; i++)
            {
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            int[] colors = new int[3];
            void GetColor(int x,int y,int size)
            {
                
                int color = board[x][y];
                if (size == 1)
                {
                    colors[color+1]++;
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
                    colors[color+1]++;
                    return;
                }
                else
                {
                    int size_ = size / 3;
                    GetColor(x, y, size_);
                    GetColor(x + size_, y, size_);
                    GetColor(x + size_*2, y, size_);
                    GetColor(x, y + size_, size_);
                    GetColor(x, y + size_*2, size_);
                    GetColor(x + size_, y + size_, size_);
                    GetColor(x + size_*2, y + size_, size_);
                    GetColor(x + size_, y + size_*2, size_);
                    GetColor(x + size_*2, y + size_*2, size_);
                }
            }
            GetColor(0, 0, N);
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
        }
    }
}
