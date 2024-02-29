using System.Globalization;

namespace BaekjoonProj
{
    internal class _24060
    {
        public static void Run(string[] args)
        {
            int[] NK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] temp = new int[NK[0]];
            bool endFlag = false;
            int depth=0, res=-1;
            void merge_sort(int p,int r)
            {
                if (p < r)
                {
                    int q = (p + r) / 2;
                    merge_sort(p, q);
                    merge_sort(q + 1, r);
                    Merge(p, q, r);
                }
            }
            void Merge(int p,int q,int r)
            {
                int i = p, j = q + 1, t = 0;
                while (i <= q && j <= r)
                {
                    if (A[i] <= A[j])
                    {
                        temp[t++] = A[i++];
                    }
                    else
                    {
                        temp[t++] = A[j++];
                    }
                }
                while (i <= q)
                {
                    temp[t++] = A[i++];
                }
                while(j <= r)
                {
                    temp[t++] = A[j++];
                }
                i = p;t = 0;
                while (i <= r)
                {
                    A[i++] = temp[t];
                    depth++;
                    if (depth >= NK[1]&&!endFlag)
                    {
                        res = temp[t];
                        endFlag = true;
                        return;
                    }
                    t++;
                }
            }
            merge_sort(0, A.Length - 1);
            Console.WriteLine(res);
        }
    }
}
