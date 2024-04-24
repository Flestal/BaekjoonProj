namespace BaekjoonProj
{
    internal class _1550
    {
        public static void Run(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int num = 0;
            int a;
            for(int i=0;i<input.Length; i++)
            {
                num *= 16;
                a = 0;
                if (input[i] >= '0' && input[i] <= '9')
                    a = input[i] - '0';
                else if (input[i] >= 'A' && input[i] <= 'F')
                    a = input[i] - 'A' + 10;
                num += a;
            }
            Console.WriteLine(num);
        }
    }
}
