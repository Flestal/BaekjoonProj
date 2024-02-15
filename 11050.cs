namespace BaekjoonProj
{
    internal class _11050
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int KF = 1, RKF = 1, NF = 1;
            for(int i = 1; i <= NK[1]; i++)
            {
                KF *= i;
            }
            for(int i = 1;i <= (NK[0] - NK[1]); i++)
            {
                RKF *= i;
            }
            for(int i = 1; i <= NK[0]; i++)
            {
                NF *= i;
            }
            Console.WriteLine((NF) / (KF * RKF));
        }
    }
}
