
namespace BaekjoonProj
{
    internal class _2577
    {
        public static void Run(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int[] uses = new int[10];
            int cal = A * B * C;
            while (cal > 0)
            {
                uses[cal%10]++;
                cal /= 10;
            }
            foreach (int i in uses)
            {
                Console.WriteLine(i);
            }
        }
    }
}
