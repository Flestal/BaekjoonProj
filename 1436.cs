namespace BaekjoonProj
{
    internal class _1436
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int cnt = 0, num = 0;
            int num_, cnt_;
            bool flag;
            while (true)
            {
                flag = false;
                num_ = num;
                cnt_ = 0;
                while (num_ > 0)
                {
                    if (num_ % 10 == 6)
                    {
                        cnt_++;
                    }
                    else
                    {
                        cnt_ = 0;
                    }
                    if (cnt_ >= 3)
                    {
                        flag = true;
                        break;
                    }
                    num_ /= 10;
                }
                if (flag)
                {
                    cnt++;
                }
                if (cnt >= N)
                {
                    Console.WriteLine(num);
                    break;
                }
                num++;
            }
        }
    }
}
