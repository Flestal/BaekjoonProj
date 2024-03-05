namespace BaekjoonProj
{
    internal class _1012
    {
        public static void Run(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int T = int.Parse(Console.ReadLine());
            for(int _=0; _<T; _++)
            {
                int[] MNK = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[,] board = new int[MNK[0], MNK[1]];
                bool[,] visited = new bool[MNK[0], MNK[1]];
                for(int i=0; i < MNK[0]; i++)
                {
                    for(int j=0; j < MNK[1]; j++)
                    {
                        visited[i, j] = true;
                    }
                }
                for(int i = 0; i < MNK[2]; i++)
                {
                    int[] XY = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    board[XY[0], XY[1]] = 1;
                    visited[XY[0], XY[1]] = false;
                }
                int cnt_danji=0;
                void DFS(int i,int j,bool start=false)
                {
                    //일단 함수 실행하고 빠른리턴
                    if (i < 0 || i >= MNK[0] || j < 0 || j >= MNK[1]) return;
                    if (visited[i, j]) return;
                    if (start) 
                    {
                        cnt_danji++;
                    }
                    visited[i, j] = true;
                    DFS(i-1, j);
                    DFS(i+1, j);
                    DFS(i, j-1);
                    DFS(i, j+1);
                }
                for(int i = 0; i < MNK[0]; i++)
                {
                    for(int j=0;j< MNK[1]; j++)
                    {
                        if (visited[i,j]) { continue; }
                        DFS(i, j,true);
                    }
                }
                
                sb.AppendLine(cnt_danji.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
