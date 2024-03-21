namespace BaekjoonProj
{
    internal class _25757
    {
        public static void Run(string[] args)
        {
            string[] TG = Console.ReadLine().Split();
            int T = int.Parse(TG[0]);
            char Game = TG[1][0];
            HashSet<string> set = new HashSet<string>();
            for(int i = 0; i < T; i++)
            {
                string input = Console.ReadLine();
                set.Add(input);
            }
            int res = 0;
            switch (Game)
            {
                case 'Y':
                    res = set.Count;break;
                case 'F':
                    res = set.Count / 2;break;
                case 'O':
                    res = set.Count / 3;break;
            }
            Console.WriteLine(res);
        }
    }
}
