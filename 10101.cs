namespace BaekjoonProj
{
    internal class _10101
    {
        public static void Run(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if ((A + B + C) != 180)
            {
                Console.WriteLine("Error");
                return;
            }
            if (A == B && B == C)
            {
                Console.WriteLine("Equilateral");
                return;
            }
            if(A == B || B == C || A == C)
            {
                Console.WriteLine("Isosceles");
                return;
            }
            Console.WriteLine("Scalene");
        }
    }
}
