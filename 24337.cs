namespace BaekjoonProj
{
    internal class _24337
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] NAB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (NAB[1] + NAB[2] > NAB[0]+1)
            {
                Console.WriteLine("-1");
                return;
            }
            int[] heights = Enumerable.Repeat(1, NAB[0]).ToArray();
            int left = NAB[1], right = NAB[2];
            int top;
            if (right <= left)
            {
                top = NAB[0] - right;
                heights[top] = left;
                for(int i = top; i < NAB[0]; i++)
                {
                    heights[i] = right--;
                }
                for(int i = 0; i < NAB[1]; i++)
                {
                    heights[top-i] = left-i;
                }
            }
            else
            {
                if (left == 1)
                    top = 0;
                else
                    top = NAB[0] - right;
                heights[top] = right;
                left--;
                for (int i = top - 1; left > 1; i--)
                {
                    heights[i] = left--;
                }
                for (int i = 0; i < right - 1; i++)
                {
                    heights[NAB[0] - 1 - i] = i + 1;
                }
            }
            sb.Append(heights[0]);
            for(int i=1; i < NAB[0]; i++)
            {
                sb.Append(' ').Append(heights[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
