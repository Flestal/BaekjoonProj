namespace BaekjoonProj
{
    internal class _17386
    {
        public static void Run(string[] args)
        {
            long getCCW(long x1, long y1, long x2, long y2, long x3, long y3)
            {
                return Math.Min(1, Math.Max(-1, (x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)));
            }
            long[] line1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] line2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long ABC = getCCW(line1[0], line1[1], line1[2], line1[3], line2[0], line2[1]);
            long ABD = getCCW(line1[0], line1[1], line1[2], line1[3], line2[2], line2[3]);
            long CDA = getCCW(line2[0], line2[1], line2[2], line2[3], line1[0], line1[1]);
            long CDB = getCCW(line2[0], line2[1], line2[2], line2[3], line1[2], line1[3]);
            if (ABC * ABD < 0 && CDA * CDB < 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
