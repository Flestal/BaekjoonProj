namespace BaekjoonProj
{
    internal class _2447
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int k = 0;
            while (N > 1)
            {
                N /= 3;
                k++;
            }
            List<string> tmp,tmp_;
            int cnt;
            List<string> GetStar(int depth)
            {
                if(depth == 0)
                {
                    return new List<string>() { "*" };
                }
                else
                {
                    tmp = GetStar(depth - 1);
                    tmp_ = new List<string>();
                    cnt = tmp.Count;
                    for(int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(tmp[i] + tmp[i] + tmp[i]);
                    }
                    for(int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(tmp[i] + new string(' ', cnt) + tmp[i]);
                    }
                    for(int i = 0; i < cnt; i++)
                    {
                        tmp_.Add(tmp[i] + tmp[i] + tmp[i]);
                    }
                    return tmp_;
                }
            }
            void WriteStar(List<string> str)
            {
                System.Text.StringBuilder sb=new System.Text.StringBuilder();
                foreach(string s in str)
                {
                    sb.AppendLine(s);
                }
                Console.WriteLine(sb);
            }
            WriteStar(GetStar(k));
        }
    }
}
