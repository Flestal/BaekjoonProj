namespace BaekjoonProj
{
    internal class _19532
    {
        public static void Run(string[] args)
        {
            int[] abcdef = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int x = -999; x <= 999; x++)
            {
                for(int y = -999; y <= 999; y++)
                {
                    if ((abcdef[0] * x - abcdef[2] == abcdef[1] * y * -1)
                        && (abcdef[3] * x - abcdef[5] == abcdef[4] * y * -1))
                    {
                        Console.WriteLine(x + " " + y);
                    }
                }
            }
        }
    }
}
