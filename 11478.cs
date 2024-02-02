namespace BaekjoonProj
{
    internal class _11478
    {
        public static void Run(string[] args)
        {
            string S = Console.ReadLine();
            HashSet<string> set = new HashSet<string>();
            for(int i=0; i<S.Length; i++)
            {
                for(int j = 1; j <= S.Length-i; j++)
                {
                    string sub = S.Substring(i, j);
                    set.Add(sub);
                }
            }
            Console.WriteLine(set.Count);
        }
    }
}
