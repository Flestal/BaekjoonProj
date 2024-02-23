namespace BaekjoonProj
{
    internal class _3273
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(A);
            int x = int.Parse(Console.ReadLine());
            int p1 = 0, p2 = N - 1;
            int sum;
            int cnt = 0;
            while (p2 > p1)
            {
                sum = A[p1] + A[p2];
                if (sum == x)
                {
                    cnt++;
                    p2--;
                }
                else if (sum > x)
                {
                    p2--;
                }else if(sum < x)
                {
                    p1++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
