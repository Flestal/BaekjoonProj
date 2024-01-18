
namespace BaekjoonProj
{
    internal class _9184
    {
        public static void Run(string[] args)
        {
            int[,,] wabc = new int[21,21,21];
            for(int i= 0; i < 21; i++)
            {
                for(int j = 0; j < 21; j++)
                {
                    for(int k=0;k< 21; k++)
                    {
                        if (i == 0 || j == 0 || k == 0)
                        {
                            wabc[i,j,k] = 1;
                            continue;
                        }
                        if (i < j && j < k)
                        {
                            wabc[i, j, k] 
                                = wabc[i, j, k-1]
                                + wabc[i, j-1, k-1]
                                - wabc[i, j-1, k];
                            continue;
                        }
                        wabc[i, j, k] =
                            wabc[i-1, j, k]
                            + wabc[i-1, j-1, k]
                            + wabc[i-1, j, k-1]
                            - wabc[i-1, j-1, k-1];
                    }
                }
            }
            int[] abc;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            while(true)
            {
                abc = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (abc[0] == -1 && abc[1] == -1 && abc[2] == -1)
                {
                    break;
                }
                sb.Append("w(" + abc[0] + ", " + abc[1] + ", " + abc[2] + ") = ");
                if (abc[0] <= 0 || abc[1] <= 0 || abc[2] <= 0)
                {
                    sb.AppendLine("1");
                }
                else if (abc[0] > 20 || abc[1] > 20 || abc[2] > 20)
                {
                    sb.AppendLine(wabc[20, 20, 20].ToString());
                }
                else
                {
                    sb.AppendLine(wabc[abc[0], abc[1], abc[2]].ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}
