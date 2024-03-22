namespace BaekjoonProj
{
    internal class _20310
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            char[] input = Console.ReadLine().ToCharArray();
            int[] nums = new int[2];
            for (int i = 0; i < input.Length; i++)
            {
                nums[input[i] - '0']++;
            }
            int cnt = 0;
            nums[0] /= 2; nums[1] /= 2;
            sb.Append(input);
            for(int i=input.Length-1; i >= 0; i--)
            {
                if (sb[i] == '0')
                {
                    sb[i] = ' ';
                    cnt++;
                    if (cnt >= nums[0]) break;
                }
            }
            cnt = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (sb[i] == '1')
                {
                    sb[i] = ' ';
                    cnt++;
                    if (cnt >= nums[1]) break;
                }
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (sb[i] == ' ') sb.Remove(i,1);
            }
            
            //for(int i = 0; i < nums[0]; i++)
            //{
            //    sb.Append('0');
            //}
            //for(int i=0;i< nums[1]; i++)
            //{
            //    sb.Append('1');
            //}
            Console.WriteLine(sb);
        }
    }
}
