namespace BaekjoonProj
{
    internal class _1009
    {
        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[][] board = new int[10][]
            {
                new int[]{10 },//0
                new int[]{1 },//1
                new int[]{6,2,4,8 },//2
                new int[]{1,3,9,7 },//3
                new int[]{6,4 },//4
                new int[]{5 },//5
                new int[]{6 },//6
                new int[]{1,7,9,3 },//7
                new int[]{6,8,4,2 },//8
                new int[]{1,9 } //9
            };
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<T; i++)
            {
                int[] ab = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = ab[0]%10;
                int b = ab[1]%board[a].Length;
                int result = board[a][b];

                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
