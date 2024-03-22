namespace BaekjoonProj
{
    internal class _2607
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char[] S = Console.ReadLine().ToCharArray();
            int[] chars = new int[26];
            int[] chars_compare;
            int sim;
            bool flag,flag2;
            int cnt = 0;
            for(int i = 0; i < S.Length; i++)
            {
                chars[S[i] - 'A']++;
            }
            for(int _=1; _<N; _++)
            {
                char[] str = Console.ReadLine().ToCharArray();
                chars_compare = new int[26];
                for (int i = 0; i < str.Length; i++)
                {
                    chars_compare[str[i] - 'A']++;
                }
                sim = 0;
                flag = true;
                flag2 = true;
                for(int i = 0; i < 26; i++)
                {
                    if (chars[i] == chars_compare[i])
                    {//글자 갯수 같으면 continue
                        continue;
                    }
                    if (chars_compare[i] - chars[i]==1)
                    {//하나를 빼야하면
                        if (sim - 1 == 0)//바꾸는 1글자에 해당이 되면
                        {
                            sim = 0;continue;
                        }
                        else if (flag)
                        {
                            sim = -1;
                            flag = false;
                            continue;
                        }
                        else
                        {//두번 이상은 안됨
                            flag2 = false;
                            break;
                        }
                    }
                    if (chars_compare[i] - chars[i] == -1)
                    {//하나를 더해야하면
                        if (sim + 1 == 0)//바꾸는 1글자에 해당이 되면
                        {
                            sim = 0; continue;
                        }
                        else if (flag)
                        {
                            sim = 1;
                            flag = false;
                            continue;
                        }
                        else
                        {//두번 이상은 안됨
                            flag2 = false;
                            break;
                        }
                    }
                    flag2 = false;
                    break;
                }
                if (flag2) cnt++;
            }
            
            Console.WriteLine(cnt);
        }
    }
}
