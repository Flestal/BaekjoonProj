namespace BaekjoonProj
{
    internal class _20125
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] board = new string[T];
            for(int i = 0; i < T; i++)
            {
                board[i] = Console.ReadLine();
            }
            bool findHead = false;
            (int, int) HeartPos = (-1, -1);
            int arm1 = 0, arm2 = 0;
            int waist = 0;
            int leg1=0,leg2=0;
            for(int i = 0; i < T; i++)
            {
                for(int j = 0; j < T; j++)
                {
                    if (!findHead && board[i][j] == '*')
                    {
                        HeartPos = (i + 1, j);
                        findHead = true;
                    }
                    if (board[i][j] != '*') continue;
                    if (i == HeartPos.Item1)
                    {
                        if (j < HeartPos.Item2)
                        {
                            arm1++;
                        }else if (j > HeartPos.Item2)
                        {
                            arm2++;
                        }
                    }
                    else if (i>HeartPos.Item1 && j == HeartPos.Item2)
                    {
                        waist++;
                    }
                    else if (i > HeartPos.Item1 && j < HeartPos.Item2)
                    {
                        leg1++;
                    }else if(i>HeartPos.Item1&&j> HeartPos.Item2)
                    {
                        leg2++;
                    }
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append((HeartPos.Item1 + 1)).Append(' ').Append((HeartPos.Item2 + 1)).AppendLine();
            sb.Append(arm1).Append(' ').Append(arm2).Append(' ').Append(waist).Append(' ').Append(leg1).Append(' ').Append(leg2).AppendLine();
            Console.WriteLine(sb);
        }
    }
}
