namespace BaekjoonProj
{
    internal class _1244
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] Team, RunnerCnt, TeamScore, Runner5th;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int _=0; _<T; _++)
            {
                int N=int.Parse(Console.ReadLine());
                Team= new int[201];
                RunnerCnt = new int[201];
                Runner5th = new int[201];
                TeamScore = new int[201];
                int[] GoalIn = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for(int i=0; i<N; i++)
                {
                    Team[GoalIn[i]]++;
                }
                int scr = 0;
                for(int i = 0; i < N; i++)
                {
                    if (Team[GoalIn[i]] < 6) continue;
                    scr++;
                    RunnerCnt[GoalIn[i]]++;
                    if (RunnerCnt[GoalIn[i]] < 5)
                    {
                        TeamScore[GoalIn[i]] += scr;
                    }
                    else if (RunnerCnt[GoalIn[i]] == 5)
                    {
                        Runner5th[GoalIn[i]] = scr;
                    }
                }
                int winner = 0, minScr = int.MaxValue;
                for(int i=1;i<201; i++)
                {
                    if (TeamScore[i] == 0) continue;
                    if (TeamScore[i] < minScr)
                    {
                        winner = i;minScr = TeamScore[i];
                    }else if (TeamScore[i] == minScr)
                    {
                        if (Runner5th[i] < Runner5th[winner])
                        {
                            winner = i;
                        }
                    }
                }
                sb.AppendLine(winner.ToString());
            }
            Console.Write(sb);
        }
    }
}
