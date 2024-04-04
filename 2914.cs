namespace BaekjoonProj
{
    internal class _2914
    {
        public static void Run(string[] args)
        {
            int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int res = AB[0] * (AB[1] - 1) + 1;
            Console.WriteLine(res);
        }
    }
}
