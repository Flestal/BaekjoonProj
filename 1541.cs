
namespace BaekjoonProj
{
    internal class _1541
    {
        public static void Run(string[] args)
        {
            string s = Console.ReadLine();
            string dOrder = System.Text.RegularExpressions.Regex.Replace(s, @"[0-9]", "");
            char[] d = { '+', '-' };
            int[] ints = Array.ConvertAll(s.Split(d), int.Parse);
            //ints[n]과 ints[n+1] 사이를 dorder[n]이 잇는 형태
            int res = ints[0],tmp=0;
            bool minusFlag = false;
            for(int i=1;i<ints.Length; i++)
            {
                //dorder[i-1]이 '-'이면 dorder[i]가 '-'이 나올 때까지 minusFlag 넣기
                if (dOrder[i-1] == '-') { minusFlag= true; }
                //minusFlag이 켜진 상태에서는 합산 값이 tmp에 저장
                if (minusFlag)
                {
                    tmp += ints[i];
                }
                else
                {
                    res += ints[i];
                }
                //minusFlag를 끌 때 tmp를 res에 합산, tmp 0으로 초기화
                if (i==ints.Length-1||dOrder[i] == '-')
                {
                    res -= tmp;
                    tmp = 0;
                    minusFlag = false;
                }
            }
            Console.WriteLine(res);
        }
    }
}
