namespace BaekjoonProj
{
    internal class _5585
    {
        public static void Run(string[] args)
        {
            int A = 1000-int.Parse(Console.ReadLine());
            int cnt = A / 500;
            A %= 500;
            cnt += A / 100;
            A %= 100;
            cnt += A / 50;
            A %= 50;
            cnt += A / 10;
            A %= 10;
            cnt += A / 5;
            A %= 5;
            cnt += A;
            Console.WriteLine(cnt);
        }
    }
}
