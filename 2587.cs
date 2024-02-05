namespace BaekjoonProj
{
    internal class _2587
    {
        public static void Run(string[] args)
        {
            int[] ints = new int[5];
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                ints[i] = int.Parse(Console.ReadLine());
                sum += ints[i];
            }
            int avg = sum / 5;
            Array.Sort(ints);
            Console.WriteLine(avg);
            Console.WriteLine(ints[2]);
        }
    }
}
