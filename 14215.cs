namespace BaekjoonProj
{
    internal class _14215
    {
        public static void Run(string[] args)
        {
            int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(ABC);
            int res = ABC.Sum();
            if (ABC[2] >= ABC[0] + ABC[1])
            {
                res = (ABC[0] + ABC[1]) * 2 - 1;
            }
            Console.WriteLine(res);
        }
    }
}
