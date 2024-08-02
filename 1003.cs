namespace BaekjoonProj
{
    internal class _1003
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            (int, int)[] fibo = new (int, int)[41];
            fibo[0] = (1, 0);
            fibo[1] = (0, 1);
            for(int i = 2;i<41;i++)
            {
                fibo[i] =
                    (
                    fibo[i - 1].Item1 + fibo[i - 2].Item1,
                    fibo[i - 1].Item2 + fibo[i - 2].Item2
                    );
            }
            for(int i=0;i<T;i++)
            {
                int N = int.Parse(Console.ReadLine());
                sb.AppendLine(fibo[N].Item1 +" " + fibo[N].Item2);
            }
            Console.WriteLine( sb );
        }
    }
}
