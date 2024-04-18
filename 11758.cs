namespace BaekjoonProj
{
    internal class _11758
    {
        public static void Run(string[] args)
        {
            long[] xy1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] xy2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] xy3 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long CCW = (xy2[0] - xy1[0]) * (xy3[1] - xy1[1]) - (xy3[0] - xy1[0]) * (xy2[1] - xy1[1]);
            if (CCW > 1) CCW = 1;
            if (CCW < -1) CCW = -1;
            Console.WriteLine(CCW);

        }
    }
}
