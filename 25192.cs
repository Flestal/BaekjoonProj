namespace BaekjoonProj
{
    internal class _25192
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //List<string> list = new List<string>();
            HashSet<string> set = new HashSet<string>();
            int gomCall = 0;
            for(int i=0;i<N;i++)
            {
                string command = Console.ReadLine();
                if (command == "ENTER")
                {
                    set.Clear();
                    continue;
                }
                if (!set.Contains(command))
                {
                    gomCall++;
                    set.Add(command);
                }
            }
            Console.WriteLine(gomCall);
        }
    }
}
