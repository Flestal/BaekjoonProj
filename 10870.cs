namespace BaekjoonProj
{
    internal class _10870
    {
        public static void Run(string[] args)
        {
            int[] fibo = new int[21];
            fibo[0] = 0;
            fibo[1] = 1;
            for(int i = 2; i < 21; i++)
            {
                fibo[i] = fibo[i-1]+fibo[i-2];
            }
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(fibo[N]);
        }
    }
}
