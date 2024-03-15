
namespace BaekjoonProj
{
    internal class _11722
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            List<int> list = new List<int>();
            int[] index = new int[N];
            for (int i = 0; i < N; i++)
            {
                if (list.Count == 0 || list[list.Count - 1] > A[i])
                {
                    list.Add(A[i]);
                    index[i] = list.Count-1;
                }
                else
                {
                    int left = 0;
                    int right = list.Count - 1;
                    while(left < right)
                    {
                        int mid = (left + right) / 2;
                        if (list[mid] <= A[i]) right = mid;
                        else left = mid + 1;
                    }
                    list[left] = A[i];
                    index[i] = left;
                }
            }
            int cnt = list.Count;
            Console.WriteLine(cnt);
        }
    }
}
