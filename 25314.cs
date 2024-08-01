namespace BaekjoonProj
{
    internal class _25314
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine())/4;
            for(int i = 0; i < N; i++)
            {
                sb.Append("long ");
            }
            sb.Append("int");

            Console.WriteLine(sb);
        }
    }
}
