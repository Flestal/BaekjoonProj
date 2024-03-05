namespace BaekjoonProj
{
    internal class _2667
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] board = new int[N,N];//[A,B]일 때 A번째 줄 B번째 칸
            bool[,] visited = new bool[N,N];//[A,B]일 때 A번째 줄 B번째 칸
            for(int i = 0; i < N; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().ToCharArray(),c=>(int)char.GetNumericValue(c));
                for(int j = 0; j < N; j++)
                {
                    board[i, j] = input[j];
                    if (input[j] == 1) { visited[i, j] = false; }
                    else { visited[i, j] = true; }//0번은 체크 안함
                }
            }
            int cnt_danji=0,cnt_apart;
            List<int> list = new List<int>();
            void DFS(int i,int j,bool start=false)
            {
                //일단 함수 실행하고 빠른리턴
                if (i < 0 || i >= N || j < 0 || j >= N) return;
                if (visited[i, j]) return;
                if (start) 
                {
                    cnt_danji++;
                }
                visited[i, j] = true;
                cnt_apart++;
                DFS(i-1, j);
                DFS(i+1, j);
                DFS(i, j-1);
                DFS(i, j+1);
            }
            for(int i = 0; i < N; i++)
            {
                for(int j=0;j< N; j++)
                {
                    if (visited[i,j]) { continue; }
                    cnt_apart = 0;
                    DFS(i, j,true);
                    list.Add(cnt_apart);
                }
            }
            list.Sort();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(cnt_danji.ToString());
            for(int i = 0; i < cnt_danji; i++)
            {
                sb.AppendLine(list[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
