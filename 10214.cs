namespace BaekjoonProj
{
    internal class _10214

    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            int Y, K;
            for(int i=0; i < T; i++)
            {
                Y = 0;K = 0;
                for (int j = 0; j < 9; j++)
                {
                    int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    Y += AB[0]; K += AB[1];
                }
                if (Y > K)
                    sb.AppendLine("Yonsei");
                else if (K > Y)
                    sb.AppendLine("Korea");
                else
                    sb.AppendLine("Draw");
            }
            Console.WriteLine(sb);
        }
    }
}
