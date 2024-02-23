namespace BaekjoonProj
{
    internal class _1644
    {
        public static void Run(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            if (N == 1)
            {
                Console.WriteLine(0);
                return;
            }

            bool[] isPrime= Enumerable.Repeat(true,N+1).ToArray();
            List<int> list = new List<int>();
            int sqrtn = (int)Math.Sqrt(N)+1;
            for(int i = 2; i < sqrtn; i++)
            {
                if (isPrime[i])
                {
                    list.Add(i);
                    for (int j = i * i; j < N + 1; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }
            for(int i = sqrtn; i < N+1; i++)
            {
                if (isPrime[i]) { list.Add(i);}
            }
            int p1 = 0, p2 = 1;
            int sum = list[p1];
            int cnt = 0;
            while (p2<list.Count)
            {
                if (sum == N)
                {
                    //Console.WriteLine("sum : ("+list[p1]+ " ~ " + list[p2-1]+") = "+N);
                    cnt++;
                }
                if (sum < N)
                {
                    sum += list[p2];
                    p2++;
                }
                else
                {
                    sum -= list[p1];
                    p1++;
                }
            }
            if (list[p2 - 1] == N)
            {
                //Console.WriteLine(list[p2 - 1] + " = " + N);
                cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
