namespace BaekjoonProj
{
    internal class _1934
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < T; i++)
            {
                int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = Math.Max(AB[0], AB[1]);
                int b = Math.Min(AB[0], AB[1]);
                int temp;
                while(b>0)
                {
                    temp = a;
                    a = b;
                    b = temp % b;
                }
                sb.AppendLine((AB[0] * AB[1] / a).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
