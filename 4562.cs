namespace BaekjoonProj
{
    internal class _4562
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < T; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (input[0] >= input[1])
                    sb.Append("MMM ");
                else
                    sb.Append("NO ");
                sb.AppendLine("BRAINS");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
