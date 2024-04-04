namespace BaekjoonProj
{
    internal class _10156
    {
        public static void Run(string[] args)
        {
            int[] KNM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int res = Math.Max(KNM[0] * KNM[1] - KNM[2],0);
            Console.WriteLine(res);
        }
    }
}
