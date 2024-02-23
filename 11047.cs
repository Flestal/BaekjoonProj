namespace BaekjoonProj
{
    internal class _11047
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] N = new int[NK[0]];
            for(int i = 0; i < NK[0]; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }
            int remain = NK[1];
            int cnt = 0;
            for(int i = NK[0]-1;i >= 0;i--)
            {
                while (remain >= N[i])
                {
                    cnt++;
                    remain -= N[i];
                }
                if (remain == 0)
                {
                    break;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
