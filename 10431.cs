namespace BaekjoonProj
{
    internal class _10431
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int sum,temp;
            for(int _=0;_<T;_++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                sum = 0;
                for(int i = 2; i < 21; i++)
                {
                    int j = i;
                    while (input[j] < input[j - 1])
                    {
                        temp = input[j];
                        input[j]= input[j - 1];
                        input[j - 1] = temp;
                        j--;
                        sum++;
                        if (j == 1) break;
                        
                    }
                }
                sb.Append(input[0]).Append(' ').AppendLine(sum.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
