
namespace BaekjoonProj
{
    internal class _22233
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<string> s = new HashSet<string>();
            for (int i = 0; i < NM[0]; i++)
            {
                string input = Console.ReadLine();
                s.Add(input);
            }
            for (int i = 0; i < NM[1]; i++)
            {
                string[] input = Console.ReadLine().Split(',');
                foreach(string str in input)
                {
                    if(s.Contains(str))
                        s.Remove(str);
                }
                sb.AppendLine(s.Count.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
