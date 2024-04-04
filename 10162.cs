namespace BaekjoonProj
{
    internal class _10162

    {
        public static void Run(string[] args)
        {
            const int A = 300, B = 60, C = 10;
            int T = int.Parse(Console.ReadLine());
            int cnt1 = 0, cnt2 = 0, cnt3 = 0;
            cnt1 = T / A;
            T %= A;
            cnt2= T / B;T %= B;
            cnt3 = T / C;T %= C;
            if (T != 0)
            {
                Console.WriteLine("-1");
                return;
            }
            Console.WriteLine(cnt1+" "+cnt2+" "+cnt3);
        }
    }
}
