namespace BaekjoonProj
{
    internal class _10103

    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int A = 100, B = 100;
            for(int i=0; i < T; i++)
            {
                int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (AB[0] > AB[1])
                    B -= AB[0];
                else if (AB[0] < AB[1])
                    A-= AB[1];
            }
            Console.WriteLine(A + "\n" + B);
        }
    }
}
