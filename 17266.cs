namespace BaekjoonProj
{
    internal class _17266
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[] X = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int left, right,max;
            if (M == 1)
            {
                left = X[0];
                right = N - X[0];
                max = Math.Max(left, right);
                Console.WriteLine(max);
                return;
            }
            left = X[0];
            right = (X[1] - X[0]) / 2;
            if ((X[1] - X[0]) % 2 != 0) right++;
            max=Math.Max(left, right);
            for(int i = 1; i < M-1; i++)
            {
                left = (X[i] - X[i - 1]) / 2;
                if ((X[i] - X[i-1]) % 2 != 0) left++;
                right = (X[i + 1] - X[i]) / 2;
                if ((X[i+1] - X[i]) % 2 != 0) right++;
                max = Math.Max(Math.Max(left, right),max);
            }
            left = (X[M - 1] - X[M - 2]) / 2;
            if ((X[M-1] - X[M-2]) % 2 != 0) left++;
            right = N - X[M - 1];
            max = Math.Max(Math.Max(left, right), max);
            Console.WriteLine(max);
        }
    }
}
