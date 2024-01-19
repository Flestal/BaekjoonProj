
namespace BaekjoonProj
{
    internal class _1463
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            short[] DP= new short[N+1];
            int temp;
            DP[1] = 0;
            for(int i = 2; i <= N; i++)
            {
                temp = DP[i - 1];
                if (i % 2 == 0 && temp > DP[i / 2]) 
                {
                    temp = DP[i / 2];
                }
                if (i % 3 == 0 && temp > DP[i / 3])
                {
                    temp = DP[i / 3];
                }
                DP[i] = (short)(temp + 1);
            }
            Console.WriteLine(DP[N]);
        }
    }
}
