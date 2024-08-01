namespace BaekjoonProj
{
    internal class _1094
    {
        public static void Run(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int cnt = 0;
            for(int i=0;i<7; i++)
            {
                if ((X & (1 << i)) == (1 << i))
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
