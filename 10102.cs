namespace BaekjoonProj
{
    internal class _10886
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int A=0;
            for(int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                if (N == 1) A++;
                else A--;
            }
            if (A > 0)
            {
                Console.WriteLine("Junhee is cute!");
            }
            else
            {
                Console.WriteLine("Junhee is not cute!");
            }
        }
    }
}
