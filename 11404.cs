namespace BaekjoonProj
{
    internal class _11404
    {
        public static void Run(string[] args)
        {
            const int MAX = 100000000;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            
            int[,] distances = new int[N,N];
            for(int i = 0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    if (i != j) distances[i, j] = MAX;
                }
            }
            
            for(int i = 0; i < M; i++)
            {
                int[] ABC = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                ABC[0]--; ABC[1]--;
                distances[ABC[0], ABC[1]] = distances[ABC[0], ABC[1]] > ABC[2] ? ABC[2] : distances[ABC[0], ABC[1]];
            }
            for(int i=0;i < N; i++)
            {
                for(int j=0;j<N; j++)
                {
                    for(int k=0;k<N; k++)
                    {
                        if (distances[j, k] > distances[j, i] + distances[i, k])
                            distances[j, k] = distances[j, i] + distances[i, k];
                    }
                }
            }

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (distances[i, j] == MAX)
                        distances[i, j] = 0;
                    sb.Append(distances[i, j]).Append(' ');
                }
                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }

            Console.Write(sb);

        }
    }
}
