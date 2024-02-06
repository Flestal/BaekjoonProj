namespace BaekjoonProj
{
    internal class _18870
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<int> sort_temp = new HashSet<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0; i<input.Length; i++)
            {
                sort_temp.Add(input[i]);
            }
            int[] ints = sort_temp.OrderBy(x=>x).ToArray();
            Dictionary<int,int> dic = new Dictionary<int,int>();
            for(int i=0;i<ints.Length;i++)
            {
                dic.Add(ints[i], i);
            }
            for(int i = 0; i < input.Length; i++)
            {
                sb.Append(dic[input[i]]).Append(" ");
            }
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine(sb);
        }
    }
}
