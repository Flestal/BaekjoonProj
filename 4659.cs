namespace BaekjoonProj
{
    internal class _4659
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "end") break;
                bool flag1 = false, flag2 = true, flag3 = true;
                int toggle = -1;
                int chain = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        flag1 = true;
                        if (toggle != 1)
                        {
                            toggle = 1;
                            chain = 1;
                        }
                        else
                        {
                            chain++;
                            if (chain >= 3) flag2 = false;
                        }
                    }
                    else
                    {
                        if (toggle != 0)
                        {
                            toggle = 0;
                            chain = 1;
                        }
                        else
                        {
                            chain++;
                            if (chain >= 3) flag2 = false;
                        }
                    }
                    if (i > 0 && c == s[i - 1])
                    {
                        if (!(c == 'e' || c == 'o'))
                        {
                            flag3 = false;
                        }
                    }
                }
                if (flag1 && flag2 && flag3)
                {
                    sb.Append('<').Append(s).AppendLine("> is acceptable.");
                }
                else
                {
                    sb.Append('<').Append(s).AppendLine("> is not acceptable.");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
