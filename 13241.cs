namespace BaekjoonProj
{
    internal class _13241
    {
        public static void Run(string[] args)
        {
            long[] AB = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a, b;
            if (AB[0] > AB[1])
            {
                a = AB[0];
                b = AB[1];
            }
            else
            {
                b = AB[0];
                a = AB[1];
            }
            long temp;
            while(b>0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }
            long l = AB[0] * AB[1] / a;
            Console.WriteLine(l);
        }
    }
}
