namespace BaekjoonProj
{
    internal class _3009
    {
        public static void Run(string[] args)
        {
            HashSet<int> set_x = new HashSet<int>();
            HashSet<int> set_y = new HashSet<int>();
            for (int i = 0; i < 3; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (!set_x.Add(xy[0]))
                {
                    set_x.Remove(xy[0]);
                }
                if (!set_y.Add(xy[1]))
                {
                    set_y.Remove(xy[1]);
                }
            }
            Console.WriteLine(set_x.ToArray()[0].ToString()+' ' + set_y.ToArray()[0].ToString());
        }
    }
}
