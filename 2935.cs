using System.Numerics;

namespace BaekjoonProj
{
    internal class _2935
    {
        public static void Run(string[] args)
        {
            BigInteger A = BigInteger.Parse(Console.ReadLine());
            char C = Console.ReadLine()[0];
            BigInteger B = BigInteger.Parse(Console.ReadLine());
            BigInteger res =A*B;
            if (C == '+')
                res = A + B;
            Console.WriteLine(res);
        }
    }
}
