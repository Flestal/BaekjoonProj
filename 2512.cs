namespace BaekjoonProj
{
    internal class _2512
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] J_ = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int MAX=int.Parse(Console.ReadLine());
            int sum = J_.Sum();
            if(sum < MAX)
            {
                Console.WriteLine(J_.Max());
                return;
            }
            Array.Sort(J_);
            int aa = 0;
            int aa_index = 0;
            int start = 0;
            int end = N-1;
            int mid=0;
            while (start+1 < end)
            {
                mid=(start+end)/2;
                if (J_[mid] > MAX / N)
                {
                    end = mid;
                }else
                {
                    start = mid;
                }
            }
            aa = J_[start];
            aa_index = start;
            if (aa > MAX/N)
            {
                Console.WriteLine(MAX / N);
                return;
            }
            aa_index++;
            sum = 0;
            for(int i = 0; i < aa_index&&i<N; i++)//J_[0]~J_[최대값]까지 합계 미리 계산
            {
                sum += J_[i];
            }
            
            int budget;
            while (true)
            {
                aa++;
                budget = MAX-sum;
                for( int i = aa_index;i<N&& J_[i] < aa; i++)//aa보다 작은 모든 J_[i] 값 제거
                {
                    //배열 끝 넘었으면 더 볼거 없음
                    budget -= J_[i];
                    sum += J_[i];
                    aa_index++;
                }
                budget -= aa*(N-aa_index);
                if (budget < 0) break;
            }
            Console.WriteLine(aa - 1);
        }
    }
}
