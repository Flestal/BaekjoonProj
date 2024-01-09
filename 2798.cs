namespace BaekjoonProj
{
    internal class _2798
    {
        public static void Run(string[] args)
        {
            string[] raw = Console.ReadLine().Split();
            int cnt = int.Parse(raw[0]);
            int max = int.Parse(raw[1]);
            raw = Console.ReadLine().Split();
            int[] ints = Array.ConvertAll(raw, int.Parse);
            int res = 0;
            for (int i = 0; i < cnt - 2; i++)
            {
                for (int j = i + 1; j < cnt - 1; j++)
                {
                    for (int k = j + 1; k < cnt; k++)
                    {
                        if ((ints[i] + ints[j] + ints[k]) <= max && (ints[i] + ints[j] + ints[k]) > res)
                        {
                            res = (ints[i] + ints[j] + ints[k]);
                        }
                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
