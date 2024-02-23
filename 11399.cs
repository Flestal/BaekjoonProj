namespace BaekjoonProj
{
    internal class _11399
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 0, res = 0;
            P=P.OrderBy(x => x).ToArray();
            for(int i = 0; i < N; i++)
            {
                sum += P[i];
                res += sum;
            }
            Console.WriteLine(res);
        }
    }
}
