namespace BaekjoonProj
{
    internal class _2440
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = N; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    sb.Append('*');
                }
                sb.Append('\n');
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
