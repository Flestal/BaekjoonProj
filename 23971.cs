namespace BaekjoonProj
{
    internal class _23971
    {
        public static void Run(string[] args)
        {
            int[] HWNM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int cnt = 0;
            for(int i = 0; i < HWNM[0]; i += HWNM[2]+1)
            {
                for(int j=0;j< HWNM[1]; j += HWNM[3]+1)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
