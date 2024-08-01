namespace BaekjoonProj
{
    internal class _2163
    {
        public static void Run(string[] args)
        {
            int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(AB[0] * AB[1] - 1);
        }
    }
}
