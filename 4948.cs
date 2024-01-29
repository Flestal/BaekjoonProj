using System.Runtime.Intrinsics.X86;

namespace BaekjoonProj
{
    internal class _4948
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] ints = new int[246913];
            ints[0] = -1; ints[1] = -1;
            for(int i = 2; i < ints.Length; i++)
            {
                ints[i] = i;
            }
            for(int i = 2; i <= 497;i++)
            {
                for(int j = 3; j < ints.Length; j++)
                {
                    if (ints[j] == -1) continue;
                    if (ints[j] % i == 0 && ints[j]>i)
                    {
                        ints[j] = -1;continue;
                    }
                }
            }
            while (true)
            {
                int N = int.Parse(Console.ReadLine());
                if(N == 0) { break; }
                int cnt = 0;
                for (int i = N + 1; i <= N * 2; i++)
                {
                    if (ints[i] != -1) cnt++;
                }
                sb.AppendLine(cnt.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
