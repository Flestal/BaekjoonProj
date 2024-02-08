
namespace BaekjoonProj
{
    internal class _11653
    {
        public static void Run(string[] args)
        {
            int N=int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while (N > 1)
            {
                int i = 2;
                while (N % i != 0)
                {
                    i++;
                }
                N /= i;
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
