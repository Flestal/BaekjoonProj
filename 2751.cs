namespace BaekjoonProj
{
    internal class _2751
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[N];
            for(int i = 0; i < N; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(ints);
            foreach(int i in ints)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
