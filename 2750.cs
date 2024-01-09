
namespace BaekjoonProj
{
    internal class _2750
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[N];
            for(int i = 0; i < N; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                ints[i] = inp;
            }
            Array.Sort(ints);
            for(int i = 0;i < N; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }
    }
}
