
namespace BaekjoonProj
{
    internal class _9610
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int q1 = 0, q2 = 0, q3 = 0, q4 = 0, axis = 0;
            for(int i = 0; i < N; i++)
            {
                int[] AB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (AB[0] == 0 || AB[1] == 0)
                    axis++;
                else if (AB[0] > 0 && AB[1] > 0)
                    q1++;
                else if (AB[0] > 0 && AB[1] < 0)
                    q4++;
                else if (AB[0] < 0 && AB[1]>0)
                    q2++;
                else if (AB[0] < 0 && AB[1]<0)
                    q3++;
            }
            Console.WriteLine("Q1: " + q1 + "\nQ2: " + q2 + "\nQ3: " + q3 + "\nQ4: " + q4 + "\nAXIS: " + axis);
        }
    }
}
