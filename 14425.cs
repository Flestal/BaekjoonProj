namespace BaekjoonProj
{
    internal class _14425
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();
            for(int i = 0; i < N; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[1] == "enter")
                {
                    set.Add(command[0]);
                }else if (command[1] == "leave")
                {
                    set.Remove(command[0]);
                }
            }
            string[] reverseSet = set.Reverse().ToArray();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach(string s in reverseSet)
            {
                sb.AppendLine(s);
            }
            Console.WriteLine(sb);
        }
    }
}
