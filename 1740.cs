using System.Collections.Immutable;

namespace BaekjoonProj
{
    internal class _1740
    {
        public static void Run(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long sum=0;
            char[] bin = Convert.ToString(N, 2).ToCharArray();
            for(long i=0;i<bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    //sum += (long)Math.Pow(3, bin.Length-i-1);
                    sum += Pow(bin.LongLength - i - 1);
                }
            }
            long Pow(long raise)
            {
                long ret = 1;
                for(long i = 0; i < raise; i++)
                {
                    ret *= 3;
                }
                return ret;
            }

            Console.WriteLine(sum);

        }
    }
}
