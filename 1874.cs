namespace BaekjoonProj
{
    internal class _2892
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string[] msg = Console.ReadLine().Split();
            for (int i = 0; i < N; i++)
            {
                if (msg[i][0] == '1')
                    sb.Append('.');
                else
                    sb.Append('-');
            }
            Console.WriteLine(sb);
        }
    }
}
