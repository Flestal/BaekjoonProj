namespace BaekjoonProj
{
    internal class _25501
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            (int,int) recursion(string s, int l,int r,int depth)
            {
                if (l >= r) { return (1,depth); }
                else if (s[l] != s[r]) { return (0,depth); }
                else { return recursion(s, l + 1, r - 1,depth+1); }
            }
            for(int i = 0; i < T; i++)
            {
                string S = Console.ReadLine();
                (int, int) ints = recursion(S, 0, S.Length-1, 1);
                Console.WriteLine(ints.Item1+" "+ints.Item2);
            }
        }
    }
}
