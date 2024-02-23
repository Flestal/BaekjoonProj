namespace BaekjoonProj
{
    internal class _2470
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(A);
            
            int p1 = 0, p2 = N - 1;
            int sum;
            int abs_min = int.MaxValue;
            int aa=-1, bb=-1;
            bool isMinus = false;
            while (p2 > p1)
            {
                sum = A[p1] + A[p2];
                if (sum < 0)
                {
                    isMinus = true;
                    sum = -sum;
                }
                else
                {
                    isMinus = false;
                }
                if (sum < abs_min)
                {
                    abs_min = sum;
                    aa = A[p1];
                    bb= A[p2];
                }
                if (isMinus)
                {
                    p1++;
                }
                else
                {
                    p2--;
                }
            }
            Console.WriteLine(aa+" "+bb);
        }
    }
}
