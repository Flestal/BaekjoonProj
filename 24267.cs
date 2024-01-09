namespace BaekjoonProj
{
    internal class _24267
    {
        public static void Run(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            int a1 = int.Parse(ss[0]),a0 = int.Parse(ss[1]);
            int c = int.Parse(Console.ReadLine());
            int n0 = int.Parse(Console.ReadLine());
            if (c < a1)
            {
                Console.WriteLine(0);
                return;
            }
            if (c == a1)
            {
                if (a0 <= 0)
                {
                    Console.WriteLine(1);
                    return;
                }
                Console.WriteLine(0);
                return;
            }
            if (n0 < a0 / (c - a1))
            {
                Console.WriteLine(0);
                return;
            }
            if ((c - a1) * n0 < a0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(1);
        }
    }
}
