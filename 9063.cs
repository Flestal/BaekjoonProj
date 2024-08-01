namespace BaekjoonProj
{
    internal class _9063
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int x1=int.MaxValue,y1=int.MaxValue,x2=int.MinValue,y2=int.MinValue;
            for(int i = 0; i < N; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (xy[0] < x1) x1 = xy[0];
                if (xy[1] < y1) y1 = xy[1];
                if (xy[0] > x2) x2 = xy[0];
                if (xy[1] > y2) y2 = xy[1];
            }
            Console.WriteLine((x2-x1)*(y2-y1));
        }
    }
}
