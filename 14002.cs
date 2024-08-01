
namespace BaekjoonProj
{
    internal class _14002
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            (int,int,List<int>)[] DP = new (int, int,List<int>)[N];
            for (int i = 0; i < N; i++)
            {
                DP[i] = (i, 1, new List<int>{ A[i]});
            }
            for(int i=1; i < N; i++)
            {
                for(int j=0;j < i; j++)
                {
                    if (A[i] > A[j])
                    {
                        if (DP[j].Item2 + 1 > DP[i].Item2)
                        {
                            DP[i].Item2 = DP[j].Item2 + 1;
                            DP[i].Item3.Clear();
                            DP[i].Item3.Add(A[i]);
                            DP[i].Item3.AddRange(DP[j].Item3);
                        }
                    }
                }
            }

            DP = DP.OrderByDescending(x => x.Item2).ToArray();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(DP[0].Item2.ToString());
            sb.Append(DP[0].Item3.Last());
            for(int i = DP[0].Item3.Count - 2; i >= 0; i--)
            {
                sb.Append(' ').Append(DP[0].Item3[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
