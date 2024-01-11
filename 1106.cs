namespace BaekjoonProj
{
    internal class _1106
    {
        public static void Run(string[] args)
        {
            int[] CN = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int[]> list = new List<int[]>();
            for (int _ = 0; _ < CN[1]; _++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                list.Add(input);
            }

            int scanCount = list.Max(x => x[1]);

            int[] DP = Enumerable.Repeat(100000000, CN[0]+scanCount+1).ToArray();
            DP[0] = 0;

            foreach (int[] item in list)
            {
                for(int i=item[1]; i<DP.Length; i++)
                {
                    DP[i] = Math.Min(DP[i-item[1]] + item[0], DP[i]);
                }
            }

            int[] res = DP.ToList().GetRange(CN[0], scanCount + 1).ToArray();
            Console.WriteLine(res.Min());
        }
    }
}
