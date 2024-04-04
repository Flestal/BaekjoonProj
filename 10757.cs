using System.Numerics;

namespace BaekjoonProj
{
    internal class _10757
    {
        public static void Run(string[] args)
        {
            BigInteger[] AB = Array.ConvertAll(Console.ReadLine().Split(),BigInteger.Parse);
            BigInteger res = AB[0] + AB[1];
            Console.WriteLine(res.ToString());

            
        }
    }
}
