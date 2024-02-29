namespace BaekjoonProj
{
    internal class _3015
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long cnt = 0,repeat;
            Stack<(long,long)> stack = new Stack<(long,long)> ();//(높이,반복) 스택
            long H;
            for(int i = 0; i < N; i++)
            {
                H = long.Parse(Console.ReadLine());
                while(stack.Count > 0&&stack.Peek().Item1<H)
                {//올라가는 방향이면 이전 값 제거
                    cnt += stack.Peek().Item2;
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    stack.Push((H, 1));
                }
                else if (stack.Peek().Item1 > H)
                {//내려가는 방향이면 내려다보는 카운트 추가
                    cnt++;
                    stack.Push((H, 1));
                }
                else if(stack.Peek().Item1 == H)
                {//같은 높이면 반복값 1 추가
                    repeat = stack.Peek().Item2 + 1;
                    stack.Pop();
                    cnt += repeat;
                    if (stack.Count == 0)
                        cnt--;
                    stack.Push((H, repeat));
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
