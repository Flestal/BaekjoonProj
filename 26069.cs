namespace BaekjoonProj
{
    internal class _26069
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            set.Add("ChongChong");
            for(int i=0;i<N;i++)
            {
                string[] command = Console.ReadLine().Split();
                if (set.Contains(command[0]))
                {
                    set.Add(command[1]);
                }
                else if (set.Contains(command[1]))
                {
                    set.Add(command[0]);
                }
            }
            Console.WriteLine(set.Count);
        }
    }
}
