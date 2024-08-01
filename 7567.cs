namespace BaekjoonProj
{
    internal class _7567
    {
        public static void Run(string[] args)
        {
            string input = Console.ReadLine();
            char last = input[0];
            int res = 10;
            for(int i = 1; i < input.Length; i++)
            {
                if (input[i] == last)
                    res += 5;
                else
                {
                    last = input[i];
                    res += 10;
                }
            }
            Console.WriteLine(res);
        }
    }
}
