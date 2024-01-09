namespace BaekjoonProj
{
    internal class _2920
    {
        public static void Run(string[] args)
        {
            string s = Console.ReadLine();
            if(s=="1 2 3 4 5 6 7 8") { Console.WriteLine("ascending");return; }
            if(s=="8 7 6 5 4 3 2 1") { Console.WriteLine("descending");return; }
            Console.WriteLine("mixed");
        }
    }
}
