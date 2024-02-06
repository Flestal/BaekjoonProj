namespace BaekjoonProj
{
    internal class _11650
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int[]> list = new List<int[]>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i = 0; i < N; i++)
            {
                list.Add(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            }
            list=list.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
            foreach (int[] ints in list)
            {
                sb.AppendLine(ints[0] + " " + ints[1]);
            }
            Console.WriteLine(sb);
        }
    }
}
