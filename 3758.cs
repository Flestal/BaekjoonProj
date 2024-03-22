namespace BaekjoonProj
{
    internal class _3758
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            int[] NKTM, IJS;
            (int,int)[,] KS;
            int[][] Teams;
            for (int _=0;_<T; _++)
            {
                NKTM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                KS = new (int, int)[NKTM[0],NKTM[1]];
                Teams = new int[NKTM[0]][];
                for(int i = 0; i < NKTM[0]; i++)
                {
                    Teams[i] = new int[4];
                    Teams[i][0] = i + 1;
                    for(int j = 0; j < NKTM[1]; j++)
                    {
                        KS[i, j] = (-1, 0);
                    }
                }
                for(int i = 0; i < NKTM[3]; i++)
                {
                    IJS = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    Teams[IJS[0]-1][3]++;
                    if (IJS[2] > KS[IJS[0] - 1, IJS[1] - 1].Item1)
                        KS[IJS[0] - 1, IJS[1] - 1] = (IJS[2], i + 1);
                    else
                        KS[IJS[0] - 1, IJS[1] - 1] = (KS[IJS[0] - 1, IJS[1] - 1].Item1, i + 1);
                }
                for(int i = 0; i < NKTM[0]; i++)
                {
                    for(int j=0;j < NKTM[1]; j++)
                    {
                        if (KS[i, j].Item1 == -1) continue;
                        Teams[i][1] += KS[i, j].Item1;
                        if (KS[i, j].Item2 > Teams[i][2]) Teams[i][2] = KS[i, j].Item2;
                    }
                }
                
                Teams = Teams.OrderByDescending(x => x[1]).ThenBy(x => x[3]).ThenBy(x => x[2]).ToArray();
                for(int i=0;i< NKTM[0]; i++)
                {
                    if (Teams[i][0] == NKTM[2])
                    {
                        sb.AppendLine((i + 1).ToString());
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
