using System.Collections;

namespace BaekjoonProj
{
    internal class _17299
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> stack = new Stack<int>();
            int[] res = Enumerable.Repeat(-1,N).ToArray();
            int[] Fn = Enumerable.Repeat(0,1000001).ToArray();//1~1000000까지 사용
            //Dictionary<int,int> Fn = new Dictionary<int,int>();
            for(int i = 0; i < N; i++)
            {
                //if (!Fn.ContainsKey(ints[i]))
                //{
                //    Fn.Add(ints[i], 0);
                //}
                Fn[ints[i]]++;//ints[i] 숫자가 등장한 횟수 저장
            }

            for(int i = N-1; i >=0; i--)
            {
                //오른쪽부터 계산, 자신보다 작은 모든 스택에 있는 숫자 지우고 스택에 자신 넣기
                //계산식은 Fn 배열에서 ints[i] 인덱스의 값 기준
                while(stack.Count > 0&&Fn[ints[i]]>=Fn[stack.Peek()])
                {
                    stack.Pop();
                }
                //나중에 계산하는 수일수록 왼쪽에 있으니까 현재 수보다 작으면 지워도 됨
                if (stack.Count>0)
                {
                    res[i] = stack.Peek();
                }
                stack.Push(ints[i]);
            }
            for(int i = 0; i < N; i++)
            {
                sb.Append(res[i]).Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
