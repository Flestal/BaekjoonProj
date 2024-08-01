namespace BaekjoonProj
{
    internal class _19941
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            char[] input = Console.ReadLine().ToCharArray();
            int cnt = 0;
            int max;
            for (int i = 0; i < NK[0]; i++)
            {
                max = Math.Min(NK[1], NK[0]-i-1);
                for(int j = 1; j <= max; j++)
                {
                    if (i + j < NK[0]
                        &&(input[i] == 'H' && input[i+j] == 'P')
                        || (input[i] == 'P' && input[i+j]=='H')
                        )
                    {
                        cnt++;
                        input[i] = 'N';
                        input[i+j] = 'N';
                        break;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
