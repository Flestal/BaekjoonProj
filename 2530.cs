namespace BaekjoonProj
{
    internal class _2530
    {
        public static void Run(string[] args)
        {
            int[] HMS = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int SPlus = int.Parse(Console.ReadLine());
            HMS[2] += SPlus;
            HMS[1] += HMS[2] / 60;
            HMS[2] %= 60;
            HMS[0] += HMS[1] / 60;
            HMS[1] %= 60;
            HMS[0] %= 24;
            Console.WriteLine(HMS[0] + " " + HMS[1] + " " + HMS[2]);
        }
    }
}
