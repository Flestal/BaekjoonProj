namespace BaekjoonProj
{
    internal class _2839
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int res = -1;
            for(int i = 0; i < N/5+1; i++)
            {
                for(int j=0; j < N/3+1; j++)
                {
                    if (i * 5 + j * 3 == N)
                    {
                        if(res == -1||res>(i+j))
                        {
                            res = i + j;
                        }
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
