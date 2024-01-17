
namespace BaekjoonProj
{
    internal class _2580
    {
        public static void Run(string[] args)
        {
            int[][] Board_Origin = new int[9][];
            int[][] Board = new int[9][];
            for (int i = 0; i < 9; i++)
            {
                Board_Origin[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            Board_Origin.CopyTo(Board, 0);
            bool FindFlag(int pos,int num)
            {
                for(int i = 0;i < 9;i++)
                {
                    if (Board[pos/9][i] == num)//가로줄 확인
                    {
                        return false;
                    }
                    if (Board[i][pos % 9] == num)//세로줄 확인
                    {
                        return false;
                    }
                }
                int row=((pos/9)/3)*3, col=((pos%9)/3)*3;
                for(int i = 0; i < 9; i++)//3x3 확인
                {
                    if (Board[row+(i/3)][col+(i%3)] == num)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool endFlag = false;
            void Find(int cur)
            {
                if (cur == 81)
                {
                    endFlag = true;
                    return;
                }
                if (Board_Origin[cur / 9][cur % 9] == 0)
                {
                    bool flag = false;
                    for (int j = 1; j <= 9; j++)
                    {
                        if (FindFlag(cur, j))
                        {
                            flag = true;
                            Board[cur / 9][cur % 9] = j;
                            Find(cur + 1);
                            if (endFlag) return;
                            Board[cur / 9][cur % 9] = 0;
                        }

                    }
                    if (!flag)
                    {
                        return;
                    }
                }
                else
                {
                    Find(cur + 1);
                    return;
                }
            }
            Find(0);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0;i < 9; i++)
            {
                for(int j=0; j < 9; j++)
                {
                    sb.Append(Board[i][j]).Append(" ");
                }
                sb.AppendLine();
            }
            sb.Remove(sb.Length - 1,1);
            Console.WriteLine(sb);
        }
    }
}
