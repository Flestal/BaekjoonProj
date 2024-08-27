namespace BaekjoonProj
{
    internal class _1026
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(A);
            Array.Sort(B);
            B = B.Reverse().ToArray();
            int res = 0;
            for(int i = 0; i < N; i++)
            {
                res += A[i] * B[i];
            }
            Console.WriteLine(res);
        }
    }
}
