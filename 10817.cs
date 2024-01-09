namespace BaekjoonProj
{
    internal class _10817
    {
        public static void Run(string[] args)
        {
            int[] abc = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Array.Sort(abc);
            Console.WriteLine(abc[1]);
        }
    }
}
