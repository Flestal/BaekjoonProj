namespace BaekjoonProj
{
    internal class _2741
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            for (int i = 0; i < N; i++)
            {
                s.AppendLine((i + 1).ToString());
            }
            Console.WriteLine(s);
        }
    }
}
