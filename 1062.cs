namespace BaekjoonProj
{
    internal class _1062
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            NK[1] -= 5;
            char[] input;
            (char, int)[] uses = new (char, int)[26];
            int bitChar;
            for (int i = 0; i < 26; i++)
            {
                uses[i] = ((char)(i + 'a'), 0);
            }
            for(int i = 0; i < NK[0]; i++)
            {
                input = Console.ReadLine().ToCharArray();
                int bit = 0;//2^26은 int 범위로 됨
                for(int j=0; j < input.Length; j++)
                {
                    bitChar = (1<<(input[j] - 'a'));
                    if ((bit & bitChar) == 0)
                        bit += bitChar;
                }
                for(int j = 26; bit > 0; j--)
                {
                    if ((bit & (1 << j)) == (1 << j))
                    {
                        bit -= (1 << j);
                        uses[j].Item2++;
                    }
                }
            }
            uses = uses.OrderByDescending(x => x.Item2).ToArray();
            int cnt = 0;

            for(int i = 0; i < 26; i++)
            {
                if (NK[1] <= 0) break;
                if (uses[i].Item1 == 'a' || uses[i].Item1 == 'n' || uses[i].Item1 == 't' || uses[i].Item1 == 'i' || uses[i].Item1 == 'c')
                    continue;
                cnt += uses[i].Item2;
                NK[1]--;
                
                
            }
            Console.WriteLine(cnt);
        }
    }
}
