
namespace BaekjoonProj
{
    internal class _19637
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Dictionary<int,string> map = new Dictionary<int,string>();
            int[] ints = new int[NM[0]];
            for(int i=0; i < NM[0]; i++)
            {
                string[] input = Console.ReadLine().Split();
                ints[i] = int.Parse(input[1]);
                if (!map.ContainsKey(int.Parse(input[1])))
                {
                    map.Add(int.Parse(input[1]), input[0]);
                }
            }
            Array.Sort(ints);
            int start,end,mid;
            int r1, r2;
            for(int j = 0; j < NM[1]; j++)
            {
                start = 0;
                end = NM[0];
                mid = (start + end) / 2;
                int input = int.Parse(Console.ReadLine());
                while (true)
                {
                    mid = (start + end) / 2;
                    if (mid == 0) r1 = 0;
                    else r1 = ints[mid - 1];
                    r2 = ints[mid];
                    if (mid == NM[0] - 1) r2++;

                    if (input > r2)
                    {
                        start = mid;
                        continue;
                    }
                    if (input < r1)
                    {
                        end = mid;
                        continue;
                    }
                    if (input == r1 && r1 > 0)
                    {
                        mid--;
                        break;
                    }
                    break;
                }
                sb.AppendLine(map[ints[mid]]);
            }
            Console.WriteLine(sb);
        }
    }
}
