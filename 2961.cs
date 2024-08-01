namespace BaekjoonProj
{
    internal class _2961
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] sour = new int[N];
            int[] bitter = new int[N];
            int res = int.MaxValue;
            for(int i = 0; i < N; i++)
            {
                int[] SB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sour[i] = SB[0];
                bitter[i] = SB[1];
            }
            //void DFS(int idx, int sourX, int BitterP)
            //{//신맛, 쓴맛은 전부 양의 정수, 쓴맛은 0이 나올 수 없음
            //    if (idx == N)
            //    {
            //        if(BitterP>0)
            //            res = Math.Min(Math.Abs(sourX - BitterP), res);
            //        return;
            //    }
            //    DFS(idx + 1, sourX * sour[idx], BitterP + bitter[idx]);
            //    DFS(idx + 1, sourX, BitterP);
            //}
            //DFS(0, 1, 0);
            int sour_, bitter_;
            for(int i = 1; i < (1 << N); i++)//(00...01)부터 N(2)까지 반복
            {
                sour_ = 1;bitter_ = 0;//신맛 쓴맛 초기화
                for(int j = 0; j < N; j++)//맨 뒤부터 자리 한칸씩 왼쪽으로 옮겨가면서 계산
                {
                    if ((i & (1 << j))!=0)//j 위치의 비트가 1이면(재료를 사용한 경우)
                    {
                        sour_ *= sour[j];//신맛곱 쓴맛합
                        bitter_ += bitter[j];
                    }
                }
                res = Math.Min(Math.Abs(sour_ - bitter_), res);//지금까지 결과중 가장 작게
            }
            Console.WriteLine(res);
        }
    }
}
