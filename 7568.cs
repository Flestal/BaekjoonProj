namespace BaekjoonProj
{
    internal class _7568
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] rate = new int[N];
            (int, int, int)[] mass = new (int, int, int)[N];
            for(int i=0; i<N; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                mass[i] = (i,xy[0],xy[1]);
            }
            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mass[j].Item2 > mass[i].Item2 && mass[j].Item3 > mass[i].Item3)
                    {
                        rate[i]++;
                    }
                }
            }

            sb.Append(rate[0]+1);
            for(int i = 1; i < N; i++)
            {
                sb.Append(' ').Append(rate[i]+1);
            }
            Console.WriteLine(sb);
        }
    }
}
