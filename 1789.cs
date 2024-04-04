namespace BaekjoonProj
{
    internal class _1789
    {
        public static void Run(string[] args)
        {
            long S = long.Parse(Console.ReadLine());
            long i = 0;
            while (S > 0)
            {
                i++;
                S -= i;
            }
            if(S<0)
                i--;
            Console.WriteLine(i);
        }
    }
}
