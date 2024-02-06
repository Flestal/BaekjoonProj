namespace BaekjoonProj
{
    internal class _10989
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[10001];
            for(int i = 0; i < N; i++)
            {
                ints[int.Parse(Console.ReadLine())]++;
            }
            using(var print = new StreamWriter(Console.OpenStandardOutput()))
            {
                for(int i = 0; i <= 10000; i++)
                {
                    if (ints[i] == 0) continue;
                    for(int j = 0; j < ints[i]; j++)
                    {
                        print.WriteLine(i);
                    }
                }
            }
            
        }
    }
}
