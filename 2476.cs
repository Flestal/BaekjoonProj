namespace BaekjoonProj
{
    internal class _2476
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int Max = int.MinValue;
            int res;
            for(int i= 0; i < T; i++)
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (ABC[0] == ABC[1] && ABC[1] == ABC[2])
                    res = 10000 + ABC[0] * 1000;
                else if (ABC[0] == ABC[1] || ABC[0] == ABC[2])
                    res = 1000 + ABC[0] * 100;
                else if (ABC[1] == ABC[2])
                    res = 1000 + ABC[1] * 100;
                else
                    res = ABC.Max() * 100;
                Max = Math.Max(res, Max);
            }
            Console.WriteLine(Max);
        }
    }
}
