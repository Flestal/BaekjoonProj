namespace BaekjoonProj
{
    internal class _10814
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<(int,string)> list = new List<(int, string)>();
            for(int i= 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split();
                list.Add((int.Parse(input[0]), input[1]));
            }
            list=list.OrderBy(x=>x.Item1).ToList();
            foreach((int,string) p in list)
            {
                sb.AppendLine(p.Item1 +" "+p.Item2);
            }
            Console.WriteLine(sb);
        }
    }
}
