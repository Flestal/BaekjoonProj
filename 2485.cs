namespace BaekjoonProj
{
    internal class _2485
    {
        public static void Run(string[] args)
        {
            int getG(int aa,int bb)
            {
                int a = aa,b = bb;
                int temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                while (b > 0)
                {
                    temp = a;
                    a = b;
                    b = temp % b;
                }
                return a;
            }
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[N];
            int[] ints_sub = new int[N-1];
            for(int i = 0; i < N; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i < N-1; i++)
            {//각 숫자 별 차이를 구함
                ints_sub[i] = ints[i + 1] - ints[i];
            }
            int G = getG(ints_sub[0],ints_sub[1]);
            for(int i=1;i < N-2; i++)
            {
                G=getG(G,getG(ints_sub[i], ints_sub[i+1]));
            }
            int cnt = (ints[N-1] - ints[0]) / G + 1 - N;
            Console.WriteLine(cnt);
        }
    }
}
