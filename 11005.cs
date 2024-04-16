
namespace BaekjoonProj
{
    internal class _11005
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            Stack<char> stack = new Stack<char>();
            int[] NB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int N = NB[0];
            int B = NB[1];
            int i;
            while (N > 0)
            {
                i = N % B;
                if (i < 10)
                {
                    stack.Push((char)(i+'0'));
                }
                else
                {
                    stack.Push((char)(i - 10 + 'A'));
                }
                N /= B;
            }
            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            Console.WriteLine(sb);
        }
    }
}
