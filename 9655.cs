namespace BaekjoonProj
{
    internal class _9655
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool flag = false;
            if ((N - 1)%4==0||(N-1)%4==2)
                flag = true;
            if((N-3)%4==0||(N-3)%4==2)
                flag = true;

            if (flag)
                Console.WriteLine("SK");
            else
                Console.WriteLine("CY");
        }
    }
}
