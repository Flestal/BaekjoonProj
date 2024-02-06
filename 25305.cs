namespace BaekjoonProj
{
    internal class _25305
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            ints=ints.OrderByDescending(x => x).ToArray();
            Console.WriteLine(ints[NK[1]-1]);
        }
    }
}
