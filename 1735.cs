namespace BaekjoonProj
{
    internal class _1735
    {
        public static void Run(string[] args)
        {
            int[] First = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] Second = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a, b;
            a = Math.Max(First[1], Second[1]); b=Math.Min(First[1],Second[1]);
            int temp;
            while (b > 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            int l = First[1] * Second[1] / a;
            int fir_l = l / First[1];
            int sec_l = l / Second[1];
            int num = First[0] * fir_l + Second[0] * sec_l;

            a = Math.Max(num, l); b = Math.Min(num, l);
            while (b > 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            num /= a;
            l /= a;
            Console.WriteLine("{0} {1}",num,l);

        }
    }
}
