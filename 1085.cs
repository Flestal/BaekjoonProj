namespace BaekjoonProj
{
    internal class _1085
    {
        public static void Run(string[] args)
        {
            int[] xywh = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int res1 = Math.Min(xywh[2] - xywh[0], xywh[3] - xywh[1]);
            int res2 = Math.Min(xywh[0], xywh[1]);
            res1 = Math.Min(res1, res2);
            Console.WriteLine(res1);
        }
    }
}
