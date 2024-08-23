namespace BaekjoonProj
{
    internal class _1015
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] sort = A.Distinct().ToArray();// O(N^2)
            Array.Sort(sort);//O(N^2)
            int[] resArr = new int[N];
            int idx = 0;
            for(int i = 0; i < sort.Length; i++)
            {
                for(int j = 0;j<N; j++)
                {
                    if (A[j] == sort[i])
                    {
                        resArr[j] = idx++; //O(N^2)
                    }
                }
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(int i in resArr)
            {
                sb.Append(i);
                sb.Append(' ');
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb.ToString());
        }
    }
}
