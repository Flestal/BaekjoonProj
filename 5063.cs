namespace BaekjoonProj
{
    internal class _5063
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i= 0; i < T; i++)
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (ABC[1] - ABC[0] > ABC[2])
                {
                    sb.AppendLine("advertise");
                }else if (ABC[1] - ABC[0] == ABC[2])
                {
                    sb.AppendLine("does not matter");
                }
                else
                {
                    sb.AppendLine("do not advertise");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
