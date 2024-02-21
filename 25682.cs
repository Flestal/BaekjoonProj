namespace BaekjoonProj
{
    internal class _25682
    {
        public static void Run(string[] args)
        {
            int[] NMK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int flag1,flag2,flag3;
            string[] board = new string[NMK[0]];
            int[][] odd_B = new int[NMK[0]][];//, odd_W=new int[NMK[0]][];
            //odd_B는 전체 판의 왼쪽 위가 B로 시작할 때, w는 반대일 때 칠해야 하는 갯수
            for(int i = 0; i < NMK[0]; i++)
            {
                board[i] = Console.ReadLine();
                odd_B[i] = new int[NMK[1]];
                //odd_W[i] = new int[NMK[1]];
                for(int j=0;j< NMK[1]; j++)
                {
                    char c = board[i][j];//'B'와 'W'로 구분

                    if (j - 1 >= 0)
                    {
                        flag1 = odd_B[i][j - 1];
                    }
                    else
                    {
                        flag1 = 0;
                    }
                    odd_B[i][j] = flag1;
                    if ((i + j) % 2 == 0)
                    {
                        if (board[i][j] == 'W')
                        {
                            odd_B[i][j]++;
                        }
                    }
                    else
                    {
                        if (board[i][j] == 'B')
                        {
                            odd_B[i][j]++;
                        }
                    }
                }
                for(int j = 0; j < NMK[1]; j++)
                {
                    if(i-1>=0)
                    {
                        flag1 = odd_B[i-1][j];
                    }
                    else
                    {
                        flag1 = 0;
                    }
                    odd_B[i][j] += flag1;
                }
            }
            int bcnt, wcnt;
            //int flag1, flag2, flag3;
            int res = int.MaxValue;
            for (int i = NMK[2] - 1; i < NMK[0]; i++)
            {
                for (int j = NMK[2] - 1; j < NMK[1]; j++)//(k-1,k-1)~(n-1,m-1)검색
                {
                    if(i - NMK[2]>=0)
                    {
                        flag1 = odd_B[i - NMK[2]][j];
                    }
                    else
                    {
                        flag1 = 0;
                    }
                    if(j - NMK[2]>=0)
                    {
                        flag2 = odd_B[i][j - NMK[2]];
                    }
                    else
                    {
                        flag2 = 0;
                    }
                    if(i - NMK[2] >= 0 && j - NMK[2]>=0)
                    {
                        flag3 = odd_B[i - NMK[2]][j - NMK[2]];
                    }
                    else
                    {
                        flag3 = 0;
                    }
                    bcnt = odd_B[i][j]-flag1-flag2+flag3;
                    wcnt = NMK[2] * NMK[2] - bcnt;
                    //Console.WriteLine("(" + i + "," + j + ") 좌표 값 : (bcnt:" + bcnt + ",wcnt:" + wcnt + ")");
                    if (res > bcnt) res = bcnt;
                    if (res > wcnt) res = wcnt;
                }
            }
            Console.WriteLine(res);
        }
    }
}
