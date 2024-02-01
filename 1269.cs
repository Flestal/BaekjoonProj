namespace BaekjoonProj
{
    internal class _1269
    {
        public static void Run(string[] args)
        {
            Console.ReadLine();
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            HashSet<int> set = new HashSet<int>();
            int cnt = 0;
            foreach (int i in A)
            {
                set.Add(i);
            }
            foreach(int i in B)
            {
                if (!set.Add(i))
                {
                    cnt++;
                }
            }
            Console.WriteLine(A.Length+B.Length-cnt*2);
        }
    }
}
