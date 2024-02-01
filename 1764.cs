namespace BaekjoonProj
{
    internal class _1764
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<string> names = new HashSet<string>();
            List<string> list = new List<string>();
            for(int i = 0; i < NM[0]; i++)
            {
                names.Add(Console.ReadLine());
            }
            for(int i = 0; i < NM[1]; i++)
            {
                string s = Console.ReadLine();
                if (!names.Add(s))
                {
                    list.Add(s);
                }
            }
            list.Sort();
            sb.AppendLine(list.Count.ToString());
            foreach(string s in list)
            {
                sb.AppendLine(s);
            }
            Console.WriteLine(sb);
        }
    }
}
