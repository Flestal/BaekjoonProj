namespace BaekjoonProj
{
    internal class _14761
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] XYN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int Fizz = XYN[0];
            int Buzz = XYN[1];
            bool flag;
            for(int i = 1; i <= XYN[2]; i++)
            {
                flag = true;
                if (i % Fizz == 0)
                {
                    flag = false;
                    sb.Append("Fizz");
                }
                if (i % Buzz == 0)
                {
                    flag = false;
                    sb.Append("Buzz");
                }
                if (flag)
                {
                    sb.Append(i);
                }
                sb.AppendLine();
            }
            Console.WriteLine(sb);
        }
    }
}
