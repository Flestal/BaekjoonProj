namespace BaekjoonProj
{
    internal class _10039
    {
        public static void Run(string[] args)
        {
            int A = Math.Max(int.Parse(Console.ReadLine()), 40);
            int B = Math.Max(int.Parse(Console.ReadLine()), 40);
            int C = Math.Max(int.Parse(Console.ReadLine()), 40);
            int D = Math.Max(int.Parse(Console.ReadLine()), 40);
            int E = Math.Max(int.Parse(Console.ReadLine()), 40);
            int avg = (A + B + C + D + E) / 5;
            Console.WriteLine(avg);
        }
    }
}
