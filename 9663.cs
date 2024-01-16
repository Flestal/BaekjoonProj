namespace BaekjoonProj
{
    internal class _9663

    {
        public static void Run(string[] args)
        {
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] queenPos = Enumerable.Repeat(-1,N).ToArray();
            int cnt = 0;
            bool flag;
            void nQueen(int cur)
            {
                if (cur==N)
                {
                    cnt++;
                    return;
                }
                for(int i = 0; i < N; i++)//cur가 현재 row, i가 현재 col
                {
                    flag = true;
                    for(int j=0;j<cur; j++)//0~cur 까지 놓인 queenPos 와 비교
                    {
                        if (i == queenPos[j])//j가 비교하는 row, queenPos[j]가 비교하는 col
                        {
                            flag = false;break;
                        }
                        if ((j - cur) == (i - queenPos[j])
                            || (j - cur) == (queenPos[j] - i))
                        {
                            flag = false;break;
                        }
                    }
                    if (flag)
                    {
                        queenPos[cur] = i;
                        nQueen(cur + 1);
                    }
                }
            }
            nQueen(0);
            Console.WriteLine(cnt);
            //sb.Append(cnt);
            //Console.WriteLine(sb);
        }
    }
}
