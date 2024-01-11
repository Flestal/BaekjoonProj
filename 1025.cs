namespace BaekjoonProj
{
    internal class _1025
    {
        public static void Run(string[] args)
        {
            //bool isSquare = int.TryParse(Math.Sqrt(a), out _);완전제곱인지 구하기
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] Board = new int[NM[0]][];
            int res = -1, temp, sqrt;
            for(int i=0; i<NM[0]; i++)
            {
                string line = Console.ReadLine();
                List<int> list_temp = new List<int>();
                foreach(char c in line)
                {
                    list_temp.Add((int)char.GetNumericValue(c));
                }
                Board[i] = list_temp.ToArray();
            }
            for(int i=0;i<Board.Length;i++)
            {
                for(int j = 0; j < Board[i].Length;j++)//1~N,1~M까지 1차for문
                {
                    for(int k = -NM[0]; k < NM[0]; k++)
                    {
                        for(int l = -NM[1]; l <NM[1]; l++)
                        //등차값 최소 -N~N,-M~M 2차for문
                        {
                            int len = 1;
                            if (k == 0 && l == 0)
                            {
                                temp = Board[i][j];
                                sqrt = (int)Math.Sqrt(temp);
                                if(sqrt*sqrt==temp)
                                {
                                    if (temp > res)
                                    {
                                        res = temp;
                                    }
                                }
                                continue;
                            }
                            while ((i + k * len) >= 0 && (j + l * len) >= 0
                                && (i + k * len) < Board.Length && (j + l * len) < Board[i].Length)
                            {
                                int ii = 0;
                                for(int m= 0; m <= len; m++)
                                {
                                    ii *= 10;
                                    ii+=Board[i + k * m][j + l * m];
                                }
                                sqrt = (int)Math.Sqrt(ii);
                                if (sqrt * sqrt == ii)
                                {
                                    if (ii > res)
                                    {
                                        res = ii;
                                    }
                                }
                                len++;
                            }
                        }
                    }
                }
            }
             Console.WriteLine(res);
        }
    }
}
