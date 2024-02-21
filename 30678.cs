namespace BaekjoonProj
{
    internal class _30678
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt;
            List<string> GetStar(int depth)
            {
                if (depth == 0)
                {
                    return new List<string>() { "*" };
                }
                else
                {
                    List<string> tmp = GetStar(depth - 1);
                    List<string> tmp_= new List<string>();
                    cnt = tmp.Count;
                    for (int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(new string(' ', cnt * 2) + tmp[i] + new string(' ', cnt * 2));
                    }
                    for (int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(new string(' ', cnt * 2) + tmp[i] + new string(' ', cnt * 2));
                    }
                    for (int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(tmp[i] + tmp[i] + tmp[i] + tmp[i] + tmp[i]);
                    }
                    for(int i= 0; i < cnt; i++)
                    {
                        tmp_.Add(new string(' ', cnt) + tmp[i] + tmp[i] + tmp[i] + new string(' ', cnt));
                    }
                    for(int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(new string(' ', cnt) + tmp[i] + new string(' ', cnt) + tmp[i] + new string(' ', cnt));
                    }
                    return tmp_;
                }
            }
            List<string> star = GetStar(N);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(string s in star)
            {
                sb.AppendLine(s);
            }
            Console.WriteLine(sb);
        }
    }
}
