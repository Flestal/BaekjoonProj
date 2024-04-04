namespace BaekjoonProj
{
    internal class programmers
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int Fizz = 3, Buzz = 5;
            bool flag;
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i.ToString()).Append(" : ");
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
                    sb.Append(i.ToString());
                sb.AppendLine();
            }
            Console.WriteLine(sb);  
        }
    }
}
