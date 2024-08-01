namespace BaekjoonProj
{
    internal class _1205
    {
        public static void Run(string[] args)
        {
            int[] NPP = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (NPP[0] == 0)
            {
                Console.WriteLine(1);
                return;
            }
            int[] rank = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            rank = rank.OrderByDescending(x => x).ToArray();
            int i = 0;
            bool flag = false;
            for (int j = 0; j < NPP[0]; j++)
            {
                if (NPP[1] < rank[j])//더 크면 i값 증가
                {
                    i++;
                } else if (NPP[1] == rank[j])//숫자가 같으면 그게 마지막 등수인지 체크
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            if (flag && NPP[0] >= NPP[2]) { i = NPP[0]; }
            i++;
            if (i > NPP[2]) i = -1;
            Console.WriteLine(i);
        }
    }
}
