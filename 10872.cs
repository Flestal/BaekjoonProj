
namespace BaekjoonProj
{
    internal class _10872
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if(N == 0) { Console.WriteLine(1);return; }
            int ftl = 1;
            for(int i=1;i<=N;i++)
                ftl *= i;
            Console.WriteLine(ftl);
        }
    }
}
