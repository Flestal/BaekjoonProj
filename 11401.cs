namespace BaekjoonProj
{
    internal class _11401
    {
        public static void Run(string[] args)
        {
            long[] ABC = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long res = 1;
            while (ABC[1] > 0)
            {
                if (ABC[1] % 2 == 1)
                {
                    res = (res * ABC[0]) % ABC[2];
                }
                ABC[0] = ((ABC[0] % ABC[2]) * (ABC[0] % ABC[2])) % ABC[2];
                ABC[1] /= 2;
            }
            Console.WriteLine(res);
        }
    }
}
