namespace BaekjoonProj
{
    internal class _2441
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    sb.Append(' ');
                }
                for(int j=i; j < N; j++)
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
