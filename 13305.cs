
namespace BaekjoonProj
{
    internal class _13305
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] rail = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] city = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] temp = new long[N];
            long CurCity = long.MaxValue;
            long res = 0;
            for(int i = 0; i < N - 1; i++)
            {
                if (CurCity > city[i])//i번 도시 기름값이 현재 사용중인 것보다 낮으면
                {
                    //주유하는 도시 교체
                    CurCity = city[i];
                }
                res += CurCity * rail[i];
            }
            Console.WriteLine(res);
        }
    }
}
