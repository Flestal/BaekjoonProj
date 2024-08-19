namespace BaekjoonProj
{
    internal class _1004
    {
        public static void Run(string[] args)
        {
            bool startEndCheck(float[] xy, (float,float,float) circle)
            {
                float[] startXY = { xy[0], xy[1] };
                float[] endXY = { xy[2], xy[3] };
                float[] circleXY = { circle.Item1, circle.Item2 };
                float circleRad = circle.Item3*circle.Item3;
                float distanceStart = (circleXY[0] - startXY[0]) * (circleXY[0] - startXY[0]) + (circleXY[1] - startXY[1]) * (circleXY[1] - startXY[1]);
                float distanceEnd = (circleXY[0] - endXY[0]) * (circleXY[0] - endXY[0]) + (circleXY[1] - endXY[1]) * (circleXY[1] - endXY[1]);
                if (
                    (distanceStart < circleRad && distanceEnd > circleRad)
                    || (distanceStart > circleRad && distanceEnd < circleRad)
                    )
                return true;
                return false;
            }
            
            int T = int.Parse(Console.ReadLine());
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int[] Ns;
            for(int i = 0; i < T; i++)
            {
                Ns = new int[50];
                float[] xy = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                (float,float,float)[] n = new (float,float,float)[int.Parse(Console.ReadLine())];
                for(int j=0;j<n.Length;j++)
                {
                    float[] line = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                    n[j] = (line[0], line[1], line[2]);
                }
                int cnt = 0;
                for(int j=0; j<n.Length; j++)
                {
                    if(startEndCheck(xy, n[j]))
                    {
                        cnt++;
                    }
                }
                sb.AppendLine(cnt.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
