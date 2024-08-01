namespace BaekjoonProj
{
    internal class _5073
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i1=0, i2=0, i3 = 0;
            while (true)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                i1 = input[0]; i2 = input[1]; i3 = input[2];
                if (i1 == 0 && i2 == 0 && i3 == 0) break;
                if (i1 + i2 <= i3 || i2 + i3 <= i1 || i3 + i1 <= i2)
                {
                    sb.AppendLine("Invalid");
                    continue;
                }
                if (i1 == i2 && i2 == i3)
                {
                    sb.AppendLine("Equilateral");
                    continue;
                }
                if (i1 == i2 || i2 == i3 || i3 == i1)
                {
                    sb.AppendLine("Isosceles");
                    continue;
                }
                sb.AppendLine("Scalene");

            }
            Console.WriteLine(sb);
        }
    }
}
