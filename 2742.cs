
namespace BaekjoonProj
{
    internal class _2742
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            for(int i = N; i > 0; i--)
            {
                s.AppendLine(i.ToString());
            }
            Console.WriteLine(s);
        }
    }
}
