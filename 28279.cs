namespace BaekjoonProj
{
    internal class _28279
    {
        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            LinkedList<int> dq = new LinkedList<int>();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for(int i=0;i<N;i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (int.Parse(command[0]))
                {
                    case 1:
                        dq.AddFirst(int.Parse(command[1]));
                        break;
                    case 2:
                        dq.AddLast(int.Parse(command[1]));
                        break;
                    case 3:
                        if (dq.Count > 0)
                        {
                            sb.AppendLine(dq.First.Value.ToString());
                            dq.RemoveFirst();
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case 4:
                        if (dq.Count > 0)
                        {
                            sb.AppendLine(dq.Last.Value.ToString());
                            dq.RemoveLast();
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case 5:
                        sb.AppendLine(dq.Count.ToString());
                        break;
                    case 6:
                        if(dq.Count == 0) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case 7:
                        if (dq.Count > 0)
                        {
                            sb.AppendLine(dq.First.Value.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case 8:
                        if (dq.Count > 0)
                        {
                            sb.AppendLine(dq.Last.Value.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;

                }
            }
            Console.Write(sb);
        }
    }
}
