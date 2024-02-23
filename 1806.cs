namespace BaekjoonProj
{
    internal class _1806
    {
        public static void Run(string[] args)
        {
            
            int[] NS = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            int p1 = 0, p2 = 1;
            int sum = A[p1];
            int cnt = int.MaxValue;
            while (p2 > p1)
            {
                
                if (sum >= NS[1])
                {
                    if (cnt > p2 - p1)
                    {
                        cnt = p2 - p1;
                    }
                    sum -= A[p1];
                    p1++;
                    
                }else if (sum < NS[1])
                {
                    if (p2 < NS[0])
                    {
                        sum += A[p2];
                        p2++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (cnt == int.MaxValue) { cnt = 0; }
            Console.WriteLine(cnt);
        }
    }
}
