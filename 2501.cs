namespace BaekjoonProj
{
    internal class _2501
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<int> temp = new HashSet<int>();
            for(int i = 1; i <= NK[0]/2; i++)
            {
                if (NK[0] % i == 0)
                {
                    temp.Add(i);
                    temp.Add(NK[0] / i);
                }
            }
            int[] g = temp.OrderBy(x => x).ToArray();
            try
            {
                Console.WriteLine(g[NK[1]-1]);
            }catch (Exception e)
            {
                Console.WriteLine(0);
            }
        }
    }
}
