namespace BaekjoonProj
{
    internal class _5355
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int _ = 0; _ < T; _++)
            {
                string[] input = Console.ReadLine().Split();
                float num = float.Parse(input[0]);
                char[] comparers = new char[input.Length-1];
                for(int i=0;i<comparers.Length;i++)
                {
                    comparers[i] = input[i + 1][0];
                }
                for(int i = 0; i < comparers.Length; i++)
                {
                    if (comparers[i] == '@')
                        num *= 3;
                    else if (comparers[i] == '%')
                        num += 5;
                    else if (comparers[i] == '#')
                        num -= 7;
                }
                sb.AppendLine(num.ToString("0.00"));
            }
            Console.WriteLine(sb);
        }
    }
}
