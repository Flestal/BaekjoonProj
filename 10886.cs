namespace BaekjoonProj
{
    internal class _10102
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int A=0, B=0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A') A++;
                else if (s[i] == 'B') B++;
            }
            Console.WriteLine((A == B) ? "Tie" : (A > B) ? "A" : "B");
        }
    }
}
