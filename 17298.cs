using System.Collections;

namespace BaekjoonProj
{
    internal class _17298
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> stack = new Stack<int>();
            int[] res = Enumerable.Repeat(-1,N).ToArray();

            for(int i = N-1; i >=0; i--)
            {
                //오른쪽부터 계산, 자신보다 작은 모든 스택에 있는 숫자 지우고 스택에 자신 넣기
                while(stack.Count > 0&&ints[i]>=stack.Peek())
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
