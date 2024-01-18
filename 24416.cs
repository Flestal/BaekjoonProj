
namespace BaekjoonProj
{
    internal class _24416
    {
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fib(int i)
            {
                if (i == 4)
                {
                    return 3;
                }
                else if(i == 5)
                {
                    return 5;
                }
                else
                {
                    return (fib(i-1)+fib(i-2));
                }
            }
            int fib_dynamic(int n)
            {
                int[] f = new int[n];
                int cnt = 1;//이 함수를 실행할 때 코드2 실행횟수가 기본 1 누적됨
                f[1] = 1; f[2] = 1;
                for(int i=3; i<n; i++)
                {
                    f[i] = f[i - 1] + f[i-2];
                    cnt++;
                }
                return cnt;
            }
            Console.WriteLine(fib(n).ToString() + " " + fib_dynamic(n).ToString());
        }
    }
}
