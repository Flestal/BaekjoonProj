namespace BaekjoonProj
{
    internal class _8979
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            (int, long)[] N = new (int, long)[NK[0]];
            long target=0;
            for (int i = 0; i < NK[0];i++)
            {
                long[] NGSC = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                N[i] = ((int)NGSC[0], NGSC[1] * 1000001 * 1000001 + NGSC[2] * 1000001 + NGSC[3]);
                if (NGSC[0] == NK[1])
                    target = NGSC[1] * 1000001 * 1000001 + NGSC[2] * 1000001 + NGSC[3];
            }
            N=N.OrderByDescending(x => x.Item2).ToArray();
            int res = 1;
            if (target == N[0].Item2)
            {
                Console.WriteLine('1');
                return;
            }
            for(int i = 1; N[i].Item2 > target; i++)
            {
                res++;
            }
            res++;
            Console.WriteLine(res);
        }
    }
}
