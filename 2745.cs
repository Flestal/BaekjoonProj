
namespace BaekjoonProj
{
    internal class _2745
    {
        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int B = int.Parse(input[1]);//B진법
            int A = 1;
            int ii;char ch;
            int num = 0;
            for(int i = input[0].Length-1; i >= 0; i--)
            {
                ch = input[0][i];
                if(ch>='0' && ch <= '9')
                {
                    ii=ch-'0';
                }
                else
                {
                    ii = (ch - 'A') + 10;
                }
                num += ii * A;
                A *= B;
            }
            Console.WriteLine(num);
        }
    }
}
