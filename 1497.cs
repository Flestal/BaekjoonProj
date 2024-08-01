using System.Collections.Immutable;

namespace BaekjoonProj
{
    internal class _1497
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] guitarsBit = new long[NK[0]];
            int max = 0;
            int min = int.MaxValue;
            for(int i = 0; i < NK[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                for(int j=0;j< NK[1]; j++)
                {
                    if (input[1][j]=='Y')//기타별 비트 저장
                        guitarsBit[i] |= 1L << (NK[1] - j-1);
                }
            }
            int bitCnt(long input)//현재 비트로 몇개 곡 가능한지 계산
            {
                int res = 0;
                while (input > 0)
                {
                    input = input & (input - 1);
                    res++;
                }
                return res;//(n-1)과 and 연산 반복 실행된 횟수=비트 내 1 갯수
            }
            void DFS(int idx, long mask, int cnt)
            {
                int Bit = bitCnt(mask);//현재 비트로 몇개 곡
                if (Bit == max && cnt < min)
                    min = cnt;//최대값이랑 같고 필요 기타 수가 더 적으면 필요 기타 수 갱신
                if (Bit > max)
                {//최대값을 갱신했으면
                    min = cnt;//최대값 갱신하고 필요 기타 수 갱신
                    max = Bit;
                }
                if (Bit == NK[1] || idx == NK[0])//모든 기타를 찾았거나 모든 곡을 찾았으면 끝
                    return;
                DFS(idx + 1, mask | guitarsBit[idx], cnt + 1);//현재 인덱스 기타를 사용했을 경우
                DFS(idx + 1, mask, cnt);//현재 인덱스 기타를 사용 안했을 경우
            }
            DFS(0, 0, 0);
            if (min == 0) min = -1;//불가능 처리
            Console.WriteLine(min);
            
        }
    }
}
